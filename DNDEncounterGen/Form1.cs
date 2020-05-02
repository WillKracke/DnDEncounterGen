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
        int[] mediumThreshold = { 75, 150, 300, 525, 825, 1299, 1650, 2250, 2550, 3300, 4200, 5250, 6600, 8100, 9750, 11550, 13500, 15600, 17850, 20250 };
        int[] hardThreshold = { 100, 200, 400, 700, 1100, 1600, 2200, 3000, 3400, 4400, 5600, 7000, 8800, 10800, 13000, 15400, 18000, 20800, 23800, 27000 };
        int[] deadlyThreshold = { 125, 250, 500, 875, 1375, 2000, 2750, 3750, 4250, 5500, 7000, 8750, 11000, 13500, 16250, 19250, 22500, 26000, 29750, 33750 };
        
        // Calculates CR, after checking if both textboxes are full. Requires num of players and level of players
        private void calcCombatRating(object sender, EventArgs e)
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
                    // Get the single PC CR from the appropriate array
                    int playerCR = 0;

                    if (rbEasy.Checked) { playerCR = easyThreshold[playerLvl - 1]; }
                    if (rbMed.Checked) { playerCR = mediumThreshold[playerLvl - 1]; }
                    if (rbHard.Checked) { playerCR = hardThreshold[playerLvl - 1]; }
                    if (rbDead.Checked) { playerCR = deadlyThreshold[playerLvl - 1]; }

                    // Calc CR, move it to output box
                    int avgCR = playerCR * numPlayers;

                    txtCR.Text = avgCR.ToString();
                }
                // If calculation error, print it to the output instead of crashing
                catch (Exception)
                {
                    txtCR.Text = "Error";
                }
            }
        }
    }
}
