namespace bysykkel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.colMap = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colLedigeSykler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLedigeLaaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblAllClosed = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inserviceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.centerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberoflocksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bysykkelStasjonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bysykkelStasjonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStations
            // 
            this.dgvStations.AllowUserToAddRows = false;
            this.dgvStations.AllowUserToDeleteRows = false;
            this.dgvStations.AllowUserToResizeRows = false;
            this.dgvStations.AutoGenerateColumns = false;
            this.dgvStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMap,
            this.idDataGridViewTextBoxColumn,
            this.inserviceDataGridViewCheckBoxColumn,
            this.centerDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.subtitleDataGridViewTextBoxColumn,
            this.numberoflocksDataGridViewTextBoxColumn,
            this.colLedigeSykler,
            this.colLedigeLaaser,
            this.availabilityDataGridViewTextBoxColumn});
            this.dgvStations.DataSource = this.bysykkelStasjonBindingSource;
            this.dgvStations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStations.Location = new System.Drawing.Point(0, 46);
            this.dgvStations.Name = "dgvStations";
            this.dgvStations.ReadOnly = true;
            this.dgvStations.RowHeadersVisible = false;
            this.dgvStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStations.Size = new System.Drawing.Size(755, 404);
            this.dgvStations.TabIndex = 0;
            this.dgvStations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStasjoner_CellContentClick);
            this.dgvStations.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStasjoner_CellFormatting);
            this.dgvStations.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvStasjoner_CellPainting);
            // 
            // colMap
            // 
            this.colMap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMap.HeaderText = "";
            this.colMap.MinimumWidth = 20;
            this.colMap.Name = "colMap";
            this.colMap.ReadOnly = true;
            this.colMap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMap.Width = 20;
            // 
            // colLedigeSykler
            // 
            this.colLedigeSykler.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colLedigeSykler.DefaultCellStyle = dataGridViewCellStyle2;
            this.colLedigeSykler.HeaderText = "Bikes";
            this.colLedigeSykler.Name = "colLedigeSykler";
            this.colLedigeSykler.ReadOnly = true;
            // 
            // colLedigeLaaser
            // 
            this.colLedigeLaaser.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colLedigeLaaser.DefaultCellStyle = dataGridViewCellStyle3;
            this.colLedigeLaaser.HeaderText = "Locks";
            this.colLedigeLaaser.Name = "colLedigeLaaser";
            this.colLedigeLaaser.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAllClosed);
            this.panel1.Controls.Add(this.lblErrorMessage);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 40);
            this.panel1.TabIndex = 1;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(124, 13);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(12, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 32);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 15;
            // 
            // lblAllClosed
            // 
            this.lblAllClosed.AutoSize = true;
            this.lblAllClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllClosed.ForeColor = System.Drawing.Color.Red;
            this.lblAllClosed.Location = new System.Drawing.Point(441, 13);
            this.lblAllClosed.Name = "lblAllClosed";
            this.lblAllClosed.Size = new System.Drawing.Size(245, 13);
            this.lblAllClosed.TabIndex = 2;
            this.lblAllClosed.Text = "All \'Bysykkel\' stations are currently closed";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 45;
            // 
            // inserviceDataGridViewCheckBoxColumn
            // 
            this.inserviceDataGridViewCheckBoxColumn.DataPropertyName = "in_service";
            this.inserviceDataGridViewCheckBoxColumn.HeaderText = "In service";
            this.inserviceDataGridViewCheckBoxColumn.Name = "inserviceDataGridViewCheckBoxColumn";
            this.inserviceDataGridViewCheckBoxColumn.ReadOnly = true;
            this.inserviceDataGridViewCheckBoxColumn.Width = 60;
            // 
            // centerDataGridViewTextBoxColumn
            // 
            this.centerDataGridViewTextBoxColumn.DataPropertyName = "center";
            this.centerDataGridViewTextBoxColumn.HeaderText = "center";
            this.centerDataGridViewTextBoxColumn.Name = "centerDataGridViewTextBoxColumn";
            this.centerDataGridViewTextBoxColumn.ReadOnly = true;
            this.centerDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Station";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // subtitleDataGridViewTextBoxColumn
            // 
            this.subtitleDataGridViewTextBoxColumn.DataPropertyName = "subtitle";
            this.subtitleDataGridViewTextBoxColumn.HeaderText = "Directions";
            this.subtitleDataGridViewTextBoxColumn.Name = "subtitleDataGridViewTextBoxColumn";
            this.subtitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.subtitleDataGridViewTextBoxColumn.Width = 200;
            // 
            // numberoflocksDataGridViewTextBoxColumn
            // 
            this.numberoflocksDataGridViewTextBoxColumn.DataPropertyName = "number_of_locks";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.numberoflocksDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.numberoflocksDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.numberoflocksDataGridViewTextBoxColumn.Name = "numberoflocksDataGridViewTextBoxColumn";
            this.numberoflocksDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberoflocksDataGridViewTextBoxColumn.Width = 55;
            // 
            // availabilityDataGridViewTextBoxColumn
            // 
            this.availabilityDataGridViewTextBoxColumn.DataPropertyName = "availability";
            this.availabilityDataGridViewTextBoxColumn.HeaderText = "Available";
            this.availabilityDataGridViewTextBoxColumn.Name = "availabilityDataGridViewTextBoxColumn";
            this.availabilityDataGridViewTextBoxColumn.ReadOnly = true;
            this.availabilityDataGridViewTextBoxColumn.Visible = false;
            this.availabilityDataGridViewTextBoxColumn.Width = 35;
            // 
            // bysykkelStasjonBindingSource
            // 
            this.bysykkelStasjonBindingSource.DataSource = typeof(bysykkel.BysykkelStation);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStations);
            this.Name = "MainForm";
            this.Text = "Bysykkel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bysykkelStasjonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStations;
        private System.Windows.Forms.BindingSource bysykkelStasjonBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.DataGridViewButtonColumn colMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inserviceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberoflocksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLedigeSykler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLedigeLaaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAllClosed;
    }
}

