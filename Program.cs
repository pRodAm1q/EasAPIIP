using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.IO;
using Newtonsoft.Json;
namespace EzIPApi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new EasyIPmaster());
        }
    }
}