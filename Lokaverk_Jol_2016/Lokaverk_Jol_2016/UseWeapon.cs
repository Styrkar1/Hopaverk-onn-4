using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class UseWeapon
    {
        private Monster _currentmonster;
        public void Useweapon(Weapon weapon)
        {
            Character chara = new Character();

            //creating weapon damage
            int damagetoMonster = RandomNumberGenerator.NumberBetween(weapon.MinimumDamage, weapon.MaximumDamage);
            //taking into account the pierce on a weapon
            _currentmonster.Mon_Defence -= weapon.Pierce_Damage;
            //taking into account the monsters defence
            damagetoMonster -= _currentmonster.Mon_Defence;

            if (_currentmonster.Mon_Defence < 0)
            {
                _currentmonster.Mon_Defence = 0;
            }

            if (damagetoMonster < 0)
            {
                damagetoMonster = 0;
            }

            //doing damage

            int critting = RandomNumberGenerator.NumberBetween(chara.crit_chance, 100);
            if (critting <= chara.crit_chance)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\nYou deal a decisive blow to the enemy!\r\n");
                damagetoMonster = damagetoMonster * 2;
                if (damagetoMonster < 0)
                {
                    damagetoMonster = 0;
                }
                _currentmonster.CurrentHitPoints -= damagetoMonster;

                Console.ResetColor();
            }

            else
            {
                if (damagetoMonster < 0)
                {
                    damagetoMonster = 0;
                }
                _currentmonster.CurrentHitPoints -= damagetoMonster;
            }

            Console.WriteLine("You hit the " + _currentmonster.Name + " for " + damagetoMonster + " points");

            //if it's dead
            if (_currentmonster.CurrentHitPoints <= 0)
            {
                Console.WriteLine("\r\nYou defeated the " + _currentmonster.Name);

                //gives xp
                chara.AddExperiencePoints(_currentmonster.RewardExperiencePoints);
                Console.WriteLine("This battle granted you {0} Experience points", _currentmonster.RewardExperiencePoints);

                chara.gold += _currentmonster.RewardGold;
                Console.WriteLine("You receive {0} Gold for your efforts", _currentmonster.RewardGold);

                //giving random loot from the monster
                List<InventoryItem> LootedItems = new List<InventoryItem>();

                foreach (LootItem lootitem in _currentmonster.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootitem.DropPercentage)
                    {
                        LootedItems.Add(new InventoryItem(lootitem.Details, 1));
                    }
                }

                //pity drops if nothing else was dropped
                if (LootedItems.Count == 0)
                {
                    foreach (LootItem lootitem in _currentmonster.LootTable)
                    {
                        if (lootitem.IsDefaultItem)
                        {
                            LootedItems.Add(new InventoryItem(lootitem.Details, 1));
                        }

                    }
                }

                //actually adding to the players inventory
                foreach (InventoryItem invitem in LootedItems)
                {
                    chara.AddItemToIventory(invitem.Details);

                    if (invitem.Quantity == 1)
                    {
                        //makes the text grammatically correct incase the player has one of this already
                        Console.WriteLine("You aquire {0} {1}", invitem.Quantity, invitem.Details.Name);
                    }

                    else
                    {
                        //makes the text grammatically correct incase the player has many of these already
                        Console.WriteLine("You aquire {0} {1}", invitem.Quantity, invitem.Details.NamePlural);
                    }
                }
            }
            //the monster is still alive
            else
            {
                int damagetoplayer = RandomNumberGenerator.NumberBetween(0, _currentmonster.MaximumDamage);


                Console.WriteLine("The {0} did {0} points of damage to you\r\nYour wounds grow ever deeper", _currentmonster.Name, damagetoplayer);
                damagetoplayer -= chara.defence;

                chara.health -= damagetoplayer;

                if (damagetoplayer < 0)
                {
                    damagetoplayer = 0;
                }

                if (chara.health <= 0)
                {
                    chara.health = 0;
                }

                Console.WriteLine("You have {0} Health remaining", chara.health);

                if (chara.health <= 0)
                {
                    Console.WriteLine("You succumb to your wounds and die");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("GAME OVER");
                    Console.ResetColor();
                    Environment.Exit(0);
                }
            }

        }
    }
}
