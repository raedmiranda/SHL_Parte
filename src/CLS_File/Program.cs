using LIB_File;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CLS_File
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            StringBuilder clipData = new StringBuilder();

            try
            {
                ReadConfig(out Settings data);
                List<ProcessedFile> files = RecursiveFileProcessor.Process(data);
                //files.ForEach(f => Console.WriteLine(f.Path));
                files.ForEach(f => clipData.AppendLine(f.Path + "\t" + "\t" + "\t" + f.Extension));
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

        private static void ReadConfig(out Settings data)
        {
            try
            {
                string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "data.json");
                string jsonString = new StreamReader(path).ReadToEnd();
                data = new JavaScriptSerializer().Deserialize<Settings>(jsonString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
