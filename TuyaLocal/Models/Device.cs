﻿namespace TuyaLocal.Models
{
    using System.Net;

    public class Device
    {
        public string Name { get; set; }

        public IPAddress IpAddress { get; set; }

        public string Id { get; set; }

        public string SecretKey { get; set; }
    }
}
