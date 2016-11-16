using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xServer.Forms
{
    public partial class FrmTor : Form
    {
        private bool Verify;
        public FrmTor(string type)
        {
            InitializeComponent();
            if(type == "setup")
            {
                this.Text = "Tor Setup";
                Verify = false;
            }
            else if(type == "verify")
            {
                this.Text = "Tor Verify";
                Verify = true;
            }
        }

        private void FrmTor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Verify)
            {
                MessageBox.Show("Select the folder containing your torrc file");
                torrc.ShowDialog();
                if (torrc.SelectedPath.Contains("torrc"))
                {
                    string[] torrclines = File.ReadAllLines(torrc.SelectedPath + "torrc");

                }
            }
        }
    }
}
