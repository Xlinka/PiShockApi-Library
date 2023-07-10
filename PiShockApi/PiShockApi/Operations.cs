using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiShockApi
{
    public class Operations
    {
        public class ShockCommand
        {
            public string? Username { get; set; }
            public string? Apikey { get; set; }
            public string? Code { get; set; }
            public string? Name { get; set; }
            public int Op { get; set; } = 0; // Set default operation number to 0 for shock
            public int Duration { get; set; }
            public int Intensity { get; set; }
        }

        public class VibrateCommand
        {
            public string? Username { get; set; }
            public string? Apikey { get; set; }
            public string? Code { get; set; }
            public string? Name { get; set; }
            public int Op { get; set; } = 1; // Set default operation number to 1 for Vibrate
            public int Duration { get; set; }
            public int Intensity { get; set; }
        }

        public class BeepCommand
        {
            public string? Username { get; set; }
            public string? Apikey { get; set; }
            public string? Code { get; set; }
            public string? Name { get; set; }
            public int Op { get; set; } = 2; // Set default operation number to 2 for Beep
            public int Duration { get; set; }
        }
    }
}
