﻿using Microsoft.WindowsAzure.Storage.Table;
using System;
using TemperatureMonitor.API.Extensions;

namespace TemperatureMonitor.API.Models
{
    public class SensorDataTableEntity : TableEntity
    {
        public SensorDataTableEntity()
        {

        }

        public SensorDataTableEntity(string key, int temperature, int humidity)
        {
            PartitionKey = key;
            RowKey = DateTime.UtcNow.ToTicks();
            Temperature = temperature;
            Humidity = humidity;
        }

        public int Temperature { get; set; }
        public int Humidity { get; set; }
    }
}