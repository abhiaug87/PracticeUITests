using NUnit.Framework;
using System.IO;

namespace PracticeUITests.Utilities
{
    public static class CommonConstants
    {
        public static class DriverSettings
        {
            public static string filepath = Path.GetFileNameWithoutExtension("chromedriver.exe"); // Create a folder called "chromedriver" under "C:\Users\yourusername\AppData\Local\Temp" & add the chrome driver version supported by your browser in this folder for the web browser to initiate
            //public static string BinaryLocationChrome = @"C:\Users\abhishek.kulkarni\AppData\Local\Temp\chromedriver";
            public static string BinaryLocationChrome = filepath;

            public static string ChromeBrowser = "Chrome";
            public static int DefaultWaitTime = 3000;
        }

        public class ApplicationSettings
        {
            public static string BaseUrl = "https://shop.countdown.co.nz/";
        }
    }
}
