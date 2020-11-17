using LIB_File;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFR_File
{
    public partial class FrmParte : Form
    {
        string VOIDFIELDS = "ALGUNOS CAMPOS ESTÁN VACÍOS";
        string INVALIDEXT = "LAS EXTENSIONES A EXCLUIR DEBEN CONTENER PUNTO (.)";
        public FrmParte()
        {
            InitializeComponent();
        }

        [STAThread]
        private void Copy(object sender, EventArgs e)
        {
            if (txtFolders.Lines.Length == 0 || txtRoutes.Lines.Length == 0) { lblResult.Text = VOIDFIELDS; return; }
            if (txtExcludes.Lines.Length > 0 && txtExcludes.Lines[0].Split(';').Any(ex => ex.IndexOfAny(".".ToCharArray()) != 0)) { lblResult.Text = INVALIDEXT; return; }
            lblResult.Text = "WORKING...";
            Settings settings = new Settings();
            settings.Folders = new List<string>(txtFolders.Lines);
            settings.ReplaceFolder = new List<string>(txtRoutes.Lines);
            settings.ExcludedExt = new List<string>(txtExcludes.Lines[0].Split(';'));
            try
            {
                List<ProcessedFile> files = RecursiveFileProcessor.Process(settings);
                StringBuilder clipData = new StringBuilder();
                files.ForEach(f => clipData.AppendLine(f.Path + "\t" + "\t" + "\t" + f.Extension));
                Clipboard.SetDataObject(clipData.ToString(), true);
                lblResult.Text = "SUCCESS!";
            }
            catch (Exception)
            {
                lblResult.Text = "ERROR!";
            }
        }
    }
}
