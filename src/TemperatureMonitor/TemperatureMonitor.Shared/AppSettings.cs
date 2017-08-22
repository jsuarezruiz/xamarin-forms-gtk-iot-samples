namespace TemperatureMonitor.Shared
{
    public static class AppSettings
    {
        public static string StorageConnectionString = "Insert your Azure Table Storage connection string";
        public static string StorageTableName = "Insert your Azure Table Storage table name";
        public static string StoragePartitionKey = "Insert your Azure Table Storage partition key";
        public static string ApiUrl = "http://YourApi.azurewebsites.net";
        public static string DefaultTimeZone = "Europe/Madrid";
    }
}