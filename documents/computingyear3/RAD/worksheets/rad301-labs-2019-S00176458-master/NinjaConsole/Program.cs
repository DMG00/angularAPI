﻿using ActivityTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity.Track("Project Structure Created");

            Activity.Track("Data Seeded");
        }
    }
}
