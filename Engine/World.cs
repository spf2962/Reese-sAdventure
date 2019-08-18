using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        // Item list
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_CHEESE_BALL = 2;
        public const int ITEM_ID_RAT_TAIL = 3;
        public const int ITEM_ID_SCRAP_LINEN = 4;
        public const int ITEM_ID_BROKEN_FANG = 5;
        public const int ITEM_ID_PIECE_OF_FUR = 6;
        public const int ITEM_ID_SNAKE_VENOM = 7;
        public const int ITEM_ID_SNAKE_FANG = 8;
        public const int ITEM_ID_SNAKE_SKIN = 9;
        public const int ITEM_ID_SPIDER_EGG = 10;
        public const int ITEM_ID_SPIDER_EYE = 11;
        public const int ITEM_ID_SPIDER_SILK = 12;
        public const int ITEM_ID_TICKET_TO_NANA = 13;
        public const int ITEM_ID_MACE = 14;
        public const int ITEM_ID_CLUB = 15;
        public const int ITEM_ID_SMALL_HEALTH_POTION = 16;
        public const int ITEM_ID_MEDIUM_HEALTH_POTION = 17;
        public const int ITEM_ID_LARGE_HEALTH_POTION = 18;
        public const int ITEM_ID_SMALL_MANA_POTION = 19;
        public const int ITEM_ID_MEDIUM_MANA_POTION = 20;
        public const int ITEM_ID_LARGE_MANA_POTION = 21;
        public const int ITEM_ID_SMALL_REJUVINATION_POTION = 22;
        public const int ITEM_ID_MEDIUM_REJUVINATION_POTION = 23;
        public const int ITEM_ID_LARGE_REJUVINATION_POTION = 24;
        public const int ITEM_ID_GRANDPA_CHEESE = 25;
        public const int ITEM_ID_NANA_STRING = 26;
        public const int ITEM_ID_LIZARD_KING_HEAD = 27;

        // Monster list
        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_LIZARD = 2;
        public const int MONSTER_ID_BAT = 3;
        public const int MONSTER_ID_WOLF = 4;
        public const int MONSTER_ID_SNAKE = 5;
        public const int MONSTER_ID_GIANT_SPIDER = 6;
        public const int MONSTER_ID_LORENZO = 7;
        public const int MONSTER_ID_MURLOC = 8;

        // Quest List

        public const int QUEST_ID_CLEAR_OLD_MACS_FARM = 1;
        public const int QUEST_ID_CLEAR_DEN_OF_SERPENTS = 2;
        public const int QUEST_ID_ASSIST_SHELBY = 3;
        public const int QUEST_ID_VISIT_NANA = 4;
        public const int QUEST_ID_DEFEAT_LORENZO = 5;
        public const int QUEST_ID_CLEAR_WEST_SHIRE = 6;
        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 7;

        // Location List
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_NANAS_HOME = 2;
        public const int LOCATION_ID_TOWN_SQUARE = 3;
        public const int LOCATION_ID_OLD_MACS_FARM = 4;
        public const int LOCATION_ID_OLD_MAC_FARM_HOUSE = 5;
        public const int LOCATION_ID_WEST_SHIRE = 6;
        public const int LOCATION_ID_GUARD_TOWER = 7;
        public const int LOCATION_ID_ALCHEMIST_HUT = 8;
        public const int LOCATION_ID_ALCHEMIST_GARDEN = 9;
        public const int LOCATION_ID_DEN_OF_SERPENTS = 10;
        public const int LOCATION_ID_BACKYARD = 11;
        public const int LOCATION_ID_OLD_WATERLOGGED_CAVE = 12;
        public const int LOCATION_ID_SPIDER_FIELD = 13;
        public const int LOCATION_ID_WEST_BRIDGE = 14;
        public const int LOCATION_ID_NORTH_BRIDGE = 15;
        public const int LOCATION_ID_SOUTH_BRIDGE = 16;
        public const int LOCATION_ID_EAST_BRIDGE = 17;
        public const int LOCATION_ID_DARKWOOD_FOREST = 18;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty Sword", "Rusty Swords", 1, 5));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10));
            Items.Add(new Weapon(ITEM_ID_MACE, "Mace", "Maces", 5, 13));

            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
            Items.Add(new Item(ITEM_ID_CHEESE_BALL, "Ball of Cheese", "Balls of Cheese"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs"));
            Items.Add(new Item(ITEM_ID_SNAKE_SKIN, "Snakeskin", "Snakeskins"));
            Items.Add(new Item(ITEM_ID_BROKEN_FANG, "Broken fang", "Broken fangs"));
            Items.Add(new Item(ITEM_ID_GRANDPA_CHEESE, "Grandpa Cheese", "Grandpa Cheese"));
            Items.Add(new Item(ITEM_ID_SCRAP_LINEN, "Srap Linen", "Scrap Linen"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
            Items.Add(new Item(ITEM_ID_SPIDER_EYE, "Spider eye", "Spider eyes"));
            Items.Add(new Item(ITEM_ID_SPIDER_EGG, "Spider egg", "Spider eggs"));
            Items.Add(new Item(ITEM_ID_SNAKE_VENOM, "Flask of Snake Venom", "Flasks of Snake Venom"));

            Items.Add(new HealingPotion(ITEM_ID_LARGE_HEALTH_POTION, "Large Health Potion", "Large Health Potions", 15));
            Items.Add(new HealingPotion(ITEM_ID_MEDIUM_HEALTH_POTION, "Medium Health Potion", "Medium Health Potions", 10));
            Items.Add(new HealingPotion(ITEM_ID_SMALL_HEALTH_POTION, "Small Health Potion", "Small Health Potions", 5));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 3, 3, 5, 5, 5);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 5, 8, 9, 9);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 65, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_SKIN), 75, true));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_VENOM), 50, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SMALL_HEALTH_POTION), 20, false));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant Spider", 20, 10, 50, 12, 12);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_EYE), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_EGG), 75, false));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 50, false));

            Monster Lorenzo = new Monster(MONSTER_ID_LORENZO, "Lorenzo: The Bold", 30, 100, 150, 33, 33);
            Lorenzo.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GRANDPA_CHEESE), 100, true));
            Lorenzo.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LARGE_HEALTH_POTION), 100, false));
            Lorenzo.LootTable.Add(new LootItem(ItemByID(ITEM_ID_TICKET_TO_NANA), 100, true));

            Monster bat = new Monster(MONSTER_ID_BAT, "Bat", 5, 5, 10, 10, 10);
            bat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BROKEN_FANG), 90, true));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
            Monsters.Add(Lorenzo);
            Monsters.Add(bat);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN, "Clear the alchemist's garden.",
                "Help Adventurer! My garden has been overrun by bats and rats! \n Please kill them all! Also would you be so kind" +
                "as to bring me back 3 rat tails and 2 pieces of fur. I will reward you with 10 pieces of cheese and a small health potion" +
                "in return.", 30, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));
            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 2));

            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_SMALL_HEALTH_POTION);

            Quest clearOldMacsFarm = new Quest(QUEST_ID_CLEAR_OLD_MACS_FARM, "Clear Old Macs Farm",
                "Oh thank heavens you have arrived adventurer! Snakes are currently rampaging through my farm. Can you please clear them out? I uhh would do" +
                "it myself but I can't get passed the tile. (Old Mac gestures toward the slippery floors). Bring me back 3 snake fangs and I shall" +
                "repay you with a ticket to Nana's and 30 pieces of cheese.", 30, 30);

            clearOldMacsFarm.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

            clearOldMacsFarm.RewardItem = ItemByID(ITEM_ID_TICKET_TO_NANA);


            Quest defeatLizardKingLorenzo = new Quest(QUEST_ID_DEFEAT_LORENZO, "Defeat the Lizard King Lorenzo in the Old Waterlogged cave", 
                "A mighty lizard has been terrorizing the locals and sicking snakes to destroy farmers crops." +
                "Bring Sheriff Bean the head of the mighty Lizard King Lorenzo in the Town Square Guard Tower", 100, 250);

            defeatLizardKingLorenzo.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_LIZARD_KING_HEAD), 1));

            defeatLizardKingLorenzo.RewardItem = ItemByID(ITEM_ID_LARGE_HEALTH_POTION);
            defeatLizardKingLorenzo.RewardItem = ItemByID(ITEM_ID_MACE);
            defeatLizardKingLorenzo.RewardItem = ItemByID(ITEM_ID_TICKET_TO_NANA);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearOldMacsFarm);
            Quests.Add(defeatLizardKingLorenzo);

        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home", "This is your house, you really need to clean up the place.");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town Square", "You see a fountain and a bounty board");
            townSquare.QuestAvailableHere = QuestByID(QUEST_ID_DEFEAT_LORENZO);

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's Hut", "There are many strange plants and fungi growing all over.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistGarden = new Location(LOCATION_ID_ALCHEMIST_GARDEN, "Alchemist's garden", "Many plants are growing here");
            alchemistGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);
            alchemistGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_BAT);

            Location oldMacsFarmHouse = new Location(LOCATION_ID_OLD_MAC_FARM_HOUSE, "Old Mac's farm house", "The house is completely carpeted from " +
                "floor to ceiling... how strange");
            oldMacsFarmHouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_OLD_MACS_FARM);

            Location oldMacsFarmField = new Location(LOCATION_ID_OLD_MACS_FARM, "Old Mac's farm field", "A pleasant field of various crops");
            oldMacsFarmField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardTower = new Location(LOCATION_ID_GUARD_TOWER, "A strong fortified tower", "There is a sign on the wall that says worlds " +
                "best Sheriff: Sheriff Aura Bean.");

            Location nanasHome = new Location(LOCATION_ID_NANAS_HOME, "Nana's Home", "The windows glow from the warmth and love inside. You can faintly" +
                "smell fresh cookies being made for guests");
            nanasHome.QuestAvailableHere = QuestByID(QUEST_ID_VISIT_NANA);

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Spider Field", "This place gives most adventurers the creeps but you don't seem" +
                "to mind. A sense of calm washes over you.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            Location oldWaterloggedCave = new Location(LOCATION_ID_OLD_WATERLOGGED_CAVE, "An old Waterlogged cave", "If you listen closely you can " +
                "hear the screams of the fallen inside... Oh wait thats just your imagination.");
            oldWaterloggedCave.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);
            oldWaterloggedCave.MonsterLivingHere = MonsterByID(MONSTER_ID_LIZARD);
            oldWaterloggedCave.MonsterLivingHere = MonsterByID(MONSTER_ID_BAT);

            Location westBridge = new Location(LOCATION_ID_WEST_BRIDGE, "West Bridge", "You see a sign that says \"Old Mac's Farm" +
                "Straight ahead, be aware of the Darkwood Forest beyond\"");

            Location northBridge = new Location(LOCATION_ID_NORTH_BRIDGE, "North Bridge", "You make out in the distance an alchemist's hut");

            Location southBridge = new Location(LOCATION_ID_SOUTH_BRIDGE, "South Bridge", "A bridge connecting your house to town square");

            Location eastBridge = new Location(LOCATION_ID_EAST_BRIDGE, "East Bridge", "Leads to spider field and Den of Serpents");

            Location denOfSerpents = new Location(LOCATION_ID_DEN_OF_SERPENTS, "Den of Serpents", "You see a sign with a skull on it, KEEP OUT!!! it reads" +
                "But you aren't afraid of a challenge are you?");
            denOfSerpents.MonsterLivingHere = MonsterByID(MONSTER_ID_LIZARD);
            denOfSerpents.MonsterLivingHere = MonsterByID(MONSTER_ID_LORENZO);

            Location backYard = new Location(LOCATION_ID_BACKYARD, "Your backyard", "Small quiet field with lots of CatNip growing... What would mom think?");

            Location westShire = new Location(LOCATION_ID_WEST_SHIRE, "West Shire", "Lots of hills and small barefoot humans live here. How strange.");

            Location darkWoodForest = new Location(LOCATION_ID_DARKWOOD_FOREST, "Dark Wood Forest", "You get the feeling that you should stick around for very" +
                "long");
            darkWoodForest.MonsterLivingHere = MonsterByID(MONSTER_ID_BAT);
            darkWoodForest.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);


            // Link the locations together
            home.LocationToNorth(southBridge);
            home.LocationToSouth(backYard);

            backYard.LocationToNorth(home);

            townSquare.LocationToSouth(southBridge);
            townSquare.LocationToNorth(northBridge);
            townSquare.LocationToEast(eastBridge);
            townSquare.LocationToWest(westBridge);

            northBridge.LocationToSouth(townSquare);
            northBridge.LocationToNorth(alchemistHut);

            southBridge.LocationToSouth(home);
            southBridge.LocationToNorth(townSquare);

            westBridge.LocationToEast(townSquare);
            westBridge.LocationToWest(oldMacsFarmHouse);

            // east of Town Square
            eastBridge.LocationToWest(townSquare);
            eastBridge.LocationToEast(guardTower);

            guardTower.LocationToWest(eastBridge);
            guardTower.LocationToEast(spiderField);

            spiderField.LocationToEast(oldWaterloggedCave);
            spiderField.LocationToWest(guardTower);

            oldWaterloggedCave.LocationToWest(spiderField);
            oldWaterloggedCave.LocationToNorth(denOfSerpents);

            denOfSerpents.LocationToSouth(oldWaterloggedCave);

            // North of Town Square
            alchemistHut.LocationToSouth(northBridge);
            alchemistHut.LocationToNorth(alchemistGarden);

            alchemistGarden.LocationToSouth(alchemistHut);

            // West of Town Square
            oldMacsFarmHouse.LocationToEast(westBridge);
            oldMacsFarmHouse.LocationToWest(oldMacsFarmField);

            oldMacsFarmField.LocationToEast(oldMacsFarmHouse);
            oldMacsFarmField.LocationToWest(darkWoodForest);

            darkWoodForest.LocationToEast(oldMacsFarmField);
            darkWoodForest.LocationToWest(westShire);

            westShire.LocationToEast(darkWoodForest);
            westShire.LocationToNorth(nanasHome);


            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(backYard);
            Locations.Add(southBridge);
            Locations.Add(northBridge);
            Locations.Add(eastBridge);
            Locations.Add(westBridge);
            Locations.Add(townSquare);
            Locations.Add(guardTower);
            Locations.Add(spiderField);
            Locations.Add(oldWaterloggedCave);
            Locations.Add(denOfSerpents);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistGarden);
            Locations.Add(oldMacsFarmHouse);
            Locations.Add(oldMacsFarmField);
            Locations.Add(darkWoodForest);
            Locations.Add(westShire);
            Locations.Add(nanasHome);

        }

        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach(Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }


    }
}
