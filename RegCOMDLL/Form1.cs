using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RegCOMDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            txtPath.Text = openFileDialog.FileName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sysfolder = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string dllname = txtPath.Text.Trim();
            if (dllname == "") return;

            if (rbReg.Checked) Process.Start(sysfolder + "\\cmd.exe", "/C regsvr32 " + dllname);
            else if (rbUnreg.Checked) Process.Start(sysfolder + "\\cmd.exe", "/C regsvr32 /U " + dllname);
        }
    }
}
