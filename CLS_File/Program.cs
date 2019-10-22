using LIB_File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLS_File
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            string[] folders = { @"C:\Publicados\Portal_Fact_Elect", @"C:\Publicados\WS_FactElect" };
            string[] excludedext = { @".config", @".datasource" };
            string[] replacefolder = { @"/ilionservices4/WS_MX_FACT_ELECT", @"/ILIONX45/custom/ShellMexico/Portal_Facturacion" };
            List<ProcessedFile> files = RecursiveFileProcessor.Main(folders, excludedext, replacefolder);
            Console.WriteLine("_-----------------------_");
            Console.WriteLine("_-----------------------_");
            files.ForEach(f => Console.WriteLine(f.Path));
            StringBuilder clipData = new StringBuilder();

            try
            {
                files.ForEach(f => clipData.AppendLine(f.Path));
                Clipboard.SetDataObject(clipData.ToString(), true);
            }
            catch (ArgumentNullException ex)
            {
                clipData.AppendLine(ex.Message);
                Clipboard.SetDataObject(clipData.ToString(), true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
