using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BusinessLayerClass objBusinessLayer = new BusinessLayerClass();
        private void BtnSaveResult_Click(object sender, EventArgs e)
        {
            try
            {
                int teamAScore = int.Parse(txtTeamA.Text);
                int teamBScore = int.Parse(txtTeamB.Text);
                

                objBusinessLayer.SaveResults(teamAScore, teamBScore);
                MessageBox.Show("SAVED");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter only numbers");
            }
            txtTeamA.Text = txtTeamB.Text = "";

        }

        private void BtnDisplayLog_Click(object sender, EventArgs e)
        {
            string log = objBusinessLayer.MakeALog();

            listLog.Items.Clear();
            listLog.Items.Add(log);
        }
    }
}
