using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Reese_sAdventure
{
    public partial class Form1 : Form
    {
        private Player _player;
        private Monster _currentMonster;

        public Form1()
        {
            InitializeComponent();
            // Creates a new constructor for the Location class and instantiates
            // it with an id (integer), name(string), description(string)
            Location location = new Location(101, "Home", "This is your house.");
            
            // Instantiate the new player object, pass in values directly to the constructor
            _player = new Player(10, 10, 500, 0, 1);

            /* Deprecated code but leaving there for now
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Cheese = 500;
            _player.ExperiencePoints = 0;
            _player.Level = 1;
            */

            lblHitpoints.Text = _player.CurrentHitPoints.ToString();
            lblCheese.Text = _player.Cheese.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnNorth_Click(object sender, EventArgs e)
        {

        }

        private void BtnUseWeapon_Click(object sender, EventArgs e)
        {

        }
    }



}
