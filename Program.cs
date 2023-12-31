using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using System.Windows;

namespace KonyvtarAsztali
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Statisztika stat = new Statisztika();
            try
            {
                stat.Feltoltes();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Environment.Exit(1);
            }
            stat.OtszaznalHosszabb();
            stat.EzerkilencszazOtvennelRegebbi();
            stat.Leghosszabb();
            stat.LegtobbKonyvvelRendelkezoSzerzo();
            /*
            if (args.Contains("--stat"))
            {
                Console.WriteLine();
            }            
            else
            {
                Application app = new Application();
                app.Run(new MainWindow());
            }*/
            Console.ReadKey();
        }
    }
}
