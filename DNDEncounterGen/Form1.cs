using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// BASE CREATURE FILES TAKEN FROM ROLL20's DATABASE
// https://roll20.net/compendium/dnd5e/Monsters%20List#content

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

        // Main list that holds all loaded creature types
        List<creature> loadedCreatures = new List<creature>();

        // Array containing each checkbox for creature options, as well as other file IO things
        List<CheckBox> creatureChecks = new List<CheckBox>();
        List<string> creaturePaths = new List<string>();


        // When form is loaded, fills in arrays with hardcoded values
        private void Form1_Load(object sender, EventArgs e)
        {
            // Adds each creature section to the list, as well as the path to the file
            creatureChecks.Add(chkAnimal); creaturePaths.Add("enemydata/animal.txt");
            creatureChecks.Add(chkCelest); creaturePaths.Add("enemydata/celestial.txt");
            creatureChecks.Add(chkConstr); creaturePaths.Add("enemydata/construct.txt");
            creatureChecks.Add(chkDemon); creaturePaths.Add("enemydata/demonic.txt");
            creatureChecks.Add(chkDragon); creaturePaths.Add("enemydata/dragon.txt");
            creatureChecks.Add(chkElement); creaturePaths.Add("enemydata/elemental.txt");
            creatureChecks.Add(chkGiant); creaturePaths.Add("enemydata/giant.txt");
            creatureChecks.Add(chkHuman); creaturePaths.Add("enemydata/humanoid.txt");
            creatureChecks.Add(chkMonster); creaturePaths.Add("enemydata/monster.txt");
            creatureChecks.Add(chkUndead); creaturePaths.Add("enemydata/undead.txt");

            // Hook up events for the CR calculator
            txtPlayerCt.TextChanged += calcCombatRating;
            txtPlayerLvl.TextChanged += calcCombatRating;
            rbEasy.CheckedChanged += calcCombatRating;
            rbMed.CheckedChanged += calcCombatRating;
            rbHard.CheckedChanged += calcCombatRating;
            rbDead.CheckedChanged += calcCombatRating;
        }

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

        // Loads all selected creatures into the main list
        private void btnLoadEnemies_Click(object sender, EventArgs e)
        {
            // Progrss bar has these stages
            // Clear list, load each selected list
            // This finds out how many steps that is
            int steps = 1; // Starting step for clearing the list
            int curr = 0; // Tracks current step
            // Adds an additional step for eached checked box
            foreach (CheckBox x in creatureChecks)
            {
                if (x.Checked)
                {
                    steps += 1;
                }
            }

            // Clears the list, first step
            loadedCreatures.Clear();
            curr += 1;
            changeProgress(curr, steps);
            // Checks to see if completed, which means nothing was checked. If so, tell the user.
            if (curr >= steps) { MessageBox.Show("Error, none selected", "Error"); return; }

            // Loads in each selected file!
            foreach (CheckBox x in creatureChecks)
            {
                if (x.Checked)
                {
                    // Opens the given file, reading each line into the list as a creature type
                    StreamReader reader = new StreamReader(creaturePaths[creatureChecks.IndexOf(x)]);
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] input = line.Split(','); // Splits the input, because it is delimited with commas
                        loadedCreatures.Add(new creature(input[0], "Filler for now", int.Parse(input[1])));
                    }

                    // Once the full file has been loaded, progress the loading bar
                    curr += 1;
                    changeProgress(curr, steps);
                }
            }
        }

        // Additional method for setting the progress bar
        private void changeProgress(int numer, int denom)
        {
            loadBar.Maximum = denom;
            loadBar.Value = numer;
        }


    }
}
