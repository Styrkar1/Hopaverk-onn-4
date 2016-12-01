using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public int Mon_Defence { get; set; }


        public List<LootItem> LootTable { get; set; }

        internal List<InventoryItem> LootItems { get; set; }

        public Monster(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold, int currentHitPoints, int maximumHitPoints, int mon_defence)
            : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            Mon_Defence = mon_defence;

            LootTable = new List<LootItem>();

            LootItems = new List<InventoryItem>();
        }

        internal Monster NewInstanceOfMonster()
        {
            Monster newMonster = new Monster(ID, Name, MaximumDamage, RewardExperiencePoints, RewardGold, CurrentHitPoints, MaximumHitPoints, Mon_Defence);

            // Add items to the lootedItems list, comparing a random number to the drop percentage
            foreach (LootItem lootItem in LootTable.Where(lootItem => RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage))
            {
                newMonster.LootItems.Add(new InventoryItem(lootItem.Details, 1));
            }

            // If no items were randomly selected, add the default loot item(s).
            if (newMonster.LootItems.Count == 0)
            {
                foreach (LootItem lootItem in LootTable.Where(x => x.IsDefaultItem))
                {
                    newMonster.LootItems.Add(new InventoryItem(lootItem.Details, 1));
                }
            }

            return newMonster;
        }
    }
}
