using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

/*
 * 
 * when generating code with xsd.exe replace all [][] by [][] 
 * for details see:
 * http://stackoverflow.com/questions/657993/system-invalidoperationexception-unable-to-generate-a-temporary-class-result-1
 * Replace all [][] with [] in your generated cs file and retry
 *
 */

namespace MyFundsXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Length property provides the number of array elements
            /*
            System.Console.WriteLine("parameter count = {0}", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                System.Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }
            Console.WriteLine(Process.GetCurrentProcess().ProcessName);
            Console.WriteLine(System.AppDomain.CurrentDomain.FriendlyName);

            string fullName = Assembly.GetEntryAssembly().Location;
            string myName = Path.GetFileNameWithoutExtension(fullName);

            Console.WriteLine("fullname: " + fullName);
            Console.WriteLine("myName: " + myName);

            Console.WriteLine("starting " + args[0]);
            Console.WriteLine(args[0] + " successfully finished");
            Console.ReadKey();
            */

            /*
                <?xml version="1.0" encoding="UTF-8" standalone="yes"?>
                <FundsXML xmlns="http://www.fundsxml.org/XMLSchema/3.1">
                    <Date>2016-01-21</Date>
                    <DataSupplier>
                    <Short>Gelion</Short>
                    </DataSupplier>
                    <UniqueDeliveryIdentification>20150827143254</UniqueDeliveryIdentification>
                    <Language>DE</Language>
                </FundsXML>
            */
            FundsXML fundsXML = new FundsXML();

            DataSupplierType dataSupplierType;
            dataSupplierType = new DataSupplierType();
            DataSupplierTypeShort _short;
            _short = new DataSupplierTypeShort();
            _short.Value = "Gelion";
            dataSupplierType.Short = _short;

            fundsXML.DataSupplier = dataSupplierType;

            fundsXML.Language = "DE";

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(fundsXML.GetType());
            x.Serialize(Console.Out, fundsXML);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
