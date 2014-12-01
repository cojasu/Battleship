using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipTest
{
    public partial class userOps : Form
    {
        public string difficulty;
        public bool humanGoesFirst;
        public bool debugMode;
        public bool demoMode;
        public userOps()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void userOps_Load(object sender, EventArgs e)
        {

        }

        private void button_clicked(object sender, EventArgs e)
        {
            this.Close();
            if (diffEasy.Checked)
                difficulty = "easy";
            else if (diffNormal.Checked)
                difficulty = "medium";
            else
                difficulty = "hard";

            if (p1Comp.Checked)
                humanGoesFirst = false;
            else
                humanGoesFirst = true;

            if (debug.Checked)
                debugMode = true;
            else
                debugMode = false;

            if (checkBoxDemoMode.Checked)
            {
                demoMode = true;
            }
            else
            {
                demoMode = false;
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
