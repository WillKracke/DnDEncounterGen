using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNDEncounterGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Create arrays with XP threshold by character level
        int[] easyThreshold = { 50, 100, 200, 350, 550, 800, 1100, 1500, 1700, 2200, 2800, 3500, 4400, 5400, 6500, 7700, 9000, 10400, 11900, 13500 };

        // When either textbox is changed for calculating CR, trigger the calculation method
        private void txtPlayerCt_TextChanged(object sender, EventArgs e)
        {
            calcCombatRating();
        }

        private void txtPlayerLvl_TextChanged(object sender, EventArgs e)
        {
            calcCombatRating();
        }
        
        // Calculates CR, after checking if both textboxes are full. Requires num of players and level of players
        private void calcCombatRating()
        {
            int numPlayers = 0;
            int playerLvl = 0;
            // Checks to make sure all boxes are filled with integer values
            if (
                txtPlayerCt.Text != null &&
                int.TryParse(txtPlayerCt.Text, out numPlayers) &&
                txtPlayerLvl.Text != null &&
                int.TryParse(txtPlayerLvl.Text, out playerLvl)
                )
            {
                try
                {
                    // Calc CR, move it to output box
                    int avgCR = easyThreshold[playerLvl - 1] * numPlayers;

                    txtCR.Text = avgCR.ToString();
                }
                catch (Exception)
                {
                    txtCR.Text = "Error";
                }
            }
        }
    }
}
