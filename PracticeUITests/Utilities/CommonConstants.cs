﻿using NUnit.Framework;
using System.IO;

namespace PracticeUITests.Utilities
{
    public static class CommonConstants
    {
        public static class DriverSettings
        {
            // running tests on chrome
            public static string filepathchrome = Path.GetFileNameWithoutExtension("chromedriver.exe"); // Create a folder called "chromedriver" under "C:\Users\yourusername\AppData\Local\Temp" & add the chrome driver version supported by your browser in this folder for the web browser to initiate. Make sure you name it as chromedriver.exe
            public static string BinaryLocationChrome = filepathchrome;

            // running tests on firefox
             public static string filepathff = Path.GetFileNameWithoutExtension("geckodriver.exe"); // Create a folder called "chromedriver" under "C:\Users\yourusername\AppData\Local\Temp" & add the chrome driver version supported by your browser in this folder for the web browser to initiate. Make sure you name it as chromedriver.exe
             public static string BinaryLocationFireFox = filepathff;
            
            // running tests on edge
            public static string filepathedge = Path.GetFileNameWithoutExtension("MicrosoftWebDriver.exe"); // Create a folder called "chromedriver" under "C:\Users\yourusername\AppData\Local\Temp" & add the chrome driver version supported by your browser in this folder for the web browser to initiate. Make sure you name it as chromedriver.exe
            public static string BinaryLocationEdge = filepathedge;

            public static string ChromeBrowser = "Chrome";
            public static string FireFoxBrowser = "FireFox";
            public static string EdgeBrowser = "Edge";
            public static string HeadlessBrowser = "Headless";
            public static int DefaultWaitTime = 3000;
        }
    }
}
