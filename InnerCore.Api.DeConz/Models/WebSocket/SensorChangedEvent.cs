﻿using InnerCore.Api.DeConz.Models.Sensors;
using System;

namespace InnerCore.Api.DeConz.Models.WebSocket
{
    public class SensorChangedEvent : EventArgs
    {
        public string Id { get; set; }

        public SensorState State { get; set; }

        public SensorConfig Config { get; set; }

        public string UniqueId { get; set; }
    }
}
