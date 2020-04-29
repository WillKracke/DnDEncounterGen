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

            }
        }
    }
}
