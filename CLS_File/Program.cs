using LIB_File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] folders = { @"C:\Publicados\Portal_Fact_Elect", @"C:\Publicados\WS_FactElect" };
            string[] excludedext = { @".config", @".datasource" };
            List<ProcessedFile> files = RecursiveFileProcessor.Main(folders, excludedext);
            string[] replacefolder = { @"/ilionservices4/" , @"/ILIONX45/custom/ShellMexico/"};
        }
    }
}
