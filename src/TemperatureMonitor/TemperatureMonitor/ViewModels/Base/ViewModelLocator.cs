using Microsoft.Practices.Unity;
using TemperatureMonitor.Services.AzureStorage;
using TemperatureMonitor.Services.RestApi;
using TemperatureMonitor.Services.Temperature;

namespace TemperatureMonitor.ViewModels.Base
{
    public class ViewModelLocator
    {
        readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = new UnityContainer();

            _container.RegisterType<TemperatureMonitorViewModel>();

            _container.RegisterType<IRestApiService, RestApiService>();
            _container.RegisterType<ITableStorageService, TableStorageService>();
            _container.RegisterType<ITemperatureSensorService, FakeTemperatureSensorService>();
        }

        public TemperatureMonitorViewModel TemperatureMonitorViewModel
        {
            get { return _container.Resolve<TemperatureMonitorViewModel>(); }
        }
    }
}