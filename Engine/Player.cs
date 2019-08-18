using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    // This is the class for the player
    // Right now in version 0.1 there are only 5 properties
    // Current and Maximum Hit points to track players health 
    // Cheese is the currency
    // Experince Points
    // Player level
    public class Player : LivingCreature
    {
        // Public defines the scope, we want this to be seen within the whole solution
        public int Cheese { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public Location CurrentLocation { get; set; }

        // Lists for the players inventory and quest log
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> QuestLog { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int cheese, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Cheese = cheese;
            ExperiencePoints = experiencePoints;
            Level = level;
            Inventory = new List<InventoryItem>();
            QuestLog = new List<PlayerQuest>();
        }
    }
}
