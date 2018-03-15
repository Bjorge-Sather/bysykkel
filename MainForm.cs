using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bysykkel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        const string IDENTIFIKATOR_FILE = "api_identifier";
        const string uriBysykkelApi_BaseAddress = "https://oslobysykkel.no/api/v1";
        const int REQ_TIMEOUT_SECS = 30;
        string identificator = "";

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvStations.AutoGenerateColumns = false;
            if (System.IO.File.Exists(IDENTIFIKATOR_FILE))
            {
                identificator = System.IO.File.ReadAllText(IDENTIFIKATOR_FILE).Trim();
            }
            showBysykkelStations();
        }

        private async Task<Stream> read(HttpClient cli, string verb)
        {
            HttpResponseMessage response = await cli.GetAsync(uriBysykkelApi_BaseAddress + verb);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                HttpResponseMessage notFoundResponse = new HttpResponseMessage(response.StatusCode);
                throw new Exception("Error calling '" + response.RequestMessage.RequestUri + "': [" + (long)response.StatusCode + "] - " + notFoundResponse.ReasonPhrase);
            }
            return await response.Content.ReadAsStreamAsync();
        }

        private async void showBysykkelStations()
        {
            using (HttpClient cli = new HttpClient())
            {
                try
                {
                    cli.Timeout = new TimeSpan(0, 0, REQ_TIMEOUT_SECS);
                    cli.DefaultRequestHeaders.Add("Client-Identifier", identificator);

                    Stream rawData = await read(cli, "/stations"); 
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(BysykkelStations));
                    BysykkelStations stations = ser.ReadObject(rawData) as BysykkelStations;

                    rawData = await read(cli, "/status");
                    ser = new DataContractJsonSerializer(typeof(BysykkelStatusOuter));
                    BysykkelStatusOuter status = ser.ReadObject(rawData) as BysykkelStatusOuter;

                    if (!status.status.all_stations_closed)
                    {

                        rawData = await read(cli, "/stations/availability");
                        ser = new DataContractJsonSerializer(typeof(BysykkelAvailabilityStations));
                        BysykkelAvailabilityStations stationsAvailability = ser.ReadObject(rawData) as BysykkelAvailabilityStations;

                        combineData(stations, stationsAvailability);
                    }
                    displayData(stations.stations, status.status.all_stations_closed);
                }
                catch (Exception e)
                {
                    displayException(e);
                }
            }
        }

        private void displayException(Exception e)
        {
            lblErrorMessage.Text = "Error: " + e.Message;
        }

        private void combineData(BysykkelStations stasjoner, BysykkelAvailabilityStations stationAvailability)
        {
            foreach (BysykkelStation stasjon in stasjoner.stations)
            {
                BysykkelAvailabilityStation availability = stationAvailability.stations.Find(a => (a as BysykkelAvailabilityStation).id == stasjon.id) as BysykkelAvailabilityStation;
                stasjon.availability = availability.availability;
            }
        }

        private void displayData(List<BysykkelStation> stations, bool allClosed)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    displayData(stations, allClosed);
                });
                return;
            }
            lblAllClosed.Visible = allClosed;
            dgvStations.DataSource = stations;
            lblErrorMessage.Text = "";
        }

        private void dgvStasjoner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStations.Columns.IndexOf(this.colMap))
            {
                BysykkelStation stasjon = (sender as DataGridView).Rows[e.RowIndex].DataBoundItem as BysykkelStation;
                string mapsUrl = @"https://www.google.com/maps/search/?api=1&query=" + stasjon.center.latitude.ToString().Replace(',', '.') + "," + stasjon.center.longitude.ToString().Replace(',', '.');
                System.Diagnostics.Process.Start(mapsUrl);
            }
        }

        private void dgvStasjoner_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BysykkelStation stasjon = (sender as DataGridView).Rows[e.RowIndex].DataBoundItem as BysykkelStation;
                if (e.ColumnIndex == dgvStations.Columns.IndexOf(this.colLedigeLaaser))
                {
                    e.Value = (stasjon.availability == null || stasjon.availability.locks == 0) ? "-" : stasjon.availability.locks.ToString();
                }
                else if (e.ColumnIndex == dgvStations.Columns.IndexOf(this.colLedigeSykler))
                {
                    e.Value = (stasjon.availability == null || stasjon.availability.bikes == 0) ? "-" : stasjon.availability.bikes.ToString();
                }
            }
        }

        private void dgvStasjoner_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvStations.Columns.IndexOf(colMap))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.map_glyph.Width;
                var h = Properties.Resources.map_glyph.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.map_glyph, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showBysykkelStations();
        }

    }
}