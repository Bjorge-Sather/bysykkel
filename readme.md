Oslo Bysykkel API demo
Author: Bjørge Sæther, bjorge@itte.no
Date: March 15, 2018

This demo was written in Visual Studio Community 2017 / C#.

OBSERVE! The only thing missing is the api identificator provided by oslo Bysykkel. For this sample, put it in a text file named 'api_identificator' located in .exe directory.
Without this file you will receive a [401] error.

Comments on solution:
I wanted to write an Android app, but didn't have a Windows machine with an OS that would run the Android emulator, so - ended up with a WinForms application :-).

Comments on the API spec / Json classes written from API examples & real-world received data:
- station.in_service was not mentioned in the API pages, but forund in returned dataset.
- I defined status.stations_closed as int[], but have really no idea whether these are station ids or not.
- Also, there is a question: What is the correlation between station.in_service and status.stations_closed ?