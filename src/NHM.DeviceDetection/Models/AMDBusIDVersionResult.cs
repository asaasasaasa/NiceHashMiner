﻿using System;
using System.Collections.Generic;

namespace NHM.DeviceDetection.Models.AMDBusIDVersionResult
{
    [Serializable]
    internal class AMDBusIDVersionResult
    {
        public string AdrenalinVersion { get; set; } = "unknown";
        public int BUS_ID { get; set; } = -1;
        public int ADLRetCode { get; set; } = -1;
		public int FunctionCall { get; set; } = -1;
    }
}
