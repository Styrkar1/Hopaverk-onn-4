using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_STEEL_SWORD = 11;
        public const int ITEM_ID_IRON_SWORD = 12;
        public const int ITEM_ID_STEEL_MACE = 13;
        public const int ITEM_ID_IRON_MACE = 14;
        public const int ITEM_ID_IRON_STAFF = 15;
        public const int ITEM_ID_STEEL_STAFF = 16;
        public const int ITEM_ID_OGRE_FLESH = 17;
        public const int ITEM_ID_OGRE_HORN = 18;
        public const int ITEM_ID_IRON_RAPIER = 19;
        public const int ITEM_ID_STEEL_RAPIER = 20;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_GIANT_OGRE = 4;

        public World()
        {

            PopulateItems();
            PopulateMonsters();

        }

        public void PopulateItems()
        {
            new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5, 5, 1);
            new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10, 10, 0);
            new Weapon(ITEM_ID_STEEL_SWORD, "Steel Sword", "Steel Swords", 15, 20, 20, 7);
            new Weapon(ITEM_ID_IRON_SWORD, "Iron Sword", "Iron Swords", 10, 15, 15, 4);
            new Weapon(ITEM_ID_STEEL_MACE, "Steel Mace", "Steel Maces", 10, 30, 20, 10);
            new Weapon(ITEM_ID_IRON_MACE, "Iron Mace", "Iron Maces", 5, 20, 15, 7);
            new Weapon(ITEM_ID_STEEL_STAFF, "Steel Staff", "Steel Staves", 16, 18, 20, 5);
            new Weapon(ITEM_ID_IRON_STAFF, "Iron Staff", "Iron staves", 12, 14, 15, 3);
            new Weapon(ITEM_ID_IRON_RAPIER, "Iron Rapier", "Iron Rapiers", 3, 30, 15, 10);
            new Weapon(ITEM_ID_STEEL_RAPIER, "Steel rapier", "Steel Rapiers", 5, 35, 20, 15);


            new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 50, 6);

            new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails", 10);
            new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur", 20);
            new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs", 10);
            new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", 10);
            new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs", 10);
            new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks", 10);
            new Item(ITEM_ID_OGRE_FLESH, "Ogre Flesh", "Ogre flesh", 20);
            new Item(ITEM_ID_OGRE_HORN, "Ogre Horn", "Ogre Horns", 20);

        }

        public static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3, 0);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, false));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, false));

            Monster giantspider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant Spider", 20, 5, 40, 10, 10, 5);
            giantspider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantspider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monster giantogre = new Monster(MONSTER_ID_GIANT_OGRE, "Giant Ogre", 30, 10, 15, 20, 20, 10);
            giantogre.LootTable.Add(new LootItem(ItemByID(ITEM_ID_OGRE_FLESH), 75, false));
            giantogre.LootTable.Add(new LootItem(ItemByID(ITEM_ID_OGRE_HORN), 25, false));


            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantspider);
            Monsters.Add(giantogre);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
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
            foreach(Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }
    }
}

