# Temperarute Monitor App (Xamarin IoT + Xamarin.Forms GTK Backend)

The Temperature Monitor App is a **Xamarin.Forms** GTK Backend App running on **Linux** that reads temperature and humidity sensor data.

![](Images/temperaturemonitor.png)

The App uploads data to **Azure Table Storage**. In Azure there are also a **Net Core Web API** that returns the data to the App, to show results in the most visual form.
Using **Oxyplot** charts the App shows the summary of temperatures and humidities per hour each day.

Xamarin.Forms, .NET Core, Linux on server and client, sounds interesting?.

## Prerequisites


- A **Raspberry Pi** 3 running Raspbian with Mono and GTK#.
- Humidity Sensor **DHT22**.
- **Visual Studio** 2017 (Windows or Mac) Community Edition and above.
- **Azure** subscription. Not a Visual Studio subscriber? Get a $25 monthly Azure credit by joining [Visual Studio Dev Essentials](https://www.visualstudio.com/products/visual-studio-dev-essentials-vs).

![](Images/requisites.png)


## How to try?

The class **AppSettings** has important configurations to add:

- **StorageConnectionString**: Connection string to the Azure Storage.
- **ApiUrl**: Base URL of the API deployed onto the App Service.

Enjoy!.

## Feedback

Please use [GitHub issues](https://github.com/jsuarezruiz/xamarin-forms-gtk-iot-samples/issues) for questions and comments.

## License

Code released under the [MIT license](https://opensource.org/licenses/MIT).