﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorApp.Model
{
    using System.ComponentModel;

    interface IModel : INotifyPropertyChanged

    {
        void Connect(string ip, int port);

        void Disconnect();

        void Start();

        //model properties
        double Heading { get; set; }

        double VerticalSpeed { get; set; }
        double AirSpeed { get; set; }

        double GroundSpeed { get; set; }

        double GpsAltitude { get; set; }

        double InternalRoll { get; set; }

        double InternalPitch { get; set; }

        double AltimeterAltitude { get; set; }

    }
}
