using System;
using System.Collections.Specialized;
using System.Drawing.Printing;
using System.Reflection;

/* Basic code to pull and enumerate printers on the local system. 
 *  Pull printer list
 *  
 * 
 */


namespace PrintConsole
{
    class Program
    {


        static void Main(string[] args)
        {

            string[] printers; 
            

            foreach (string printer in printer_list)
            {

                Console.Write(" Printer Found: {0}", printer);
            }
            

        }
    }



    class GetPrinters
    {

        public string[] printernames()
        {
            ManagementObjectSearcher printerQuery = new ManagementObjectSearcher("SELECT * from Win32_Printer");
            string[] printer_names= new string[printerQuery.Length];

            var printerArray = Array.Empty<string>();
            Array.Resize(ref printerArray, printerQuery.Length);

            foreach (printer in printerQuery.Get())
            {
                printerArray(printer.GetPropertyValue("Name"));
                status = printer.GetPropertyValue("Status");
                isDefault = printer.GetPropertyValue("Default");
                isNetworkPrinter = printer.GetPropertyValue("Network");

                Console.WriteLine("{0} (Status: {1}, Default: {2}, Network: {3}", 
                        name, 
                        status, 
                        isDefault, 
                        isNetworkPrinter
                );
            }

        }
}
}
