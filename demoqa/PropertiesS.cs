﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqa
{
    class PropertiesS
    {
        public static IWebDriver driver { get; set; }
        public static IAlert alert { get; set; }

        public static void Sleep(int time)
        {
            Thread.Sleep(time);
        }

    }
}
