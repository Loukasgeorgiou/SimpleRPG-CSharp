using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Locations
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemsRequiredToEnter {  get; set; }
        public Quest QuestAvailableHere {  get; set; }
        public Monster MonsterLivingHere {  get; set; }
        public Locations LocationToNorth { get; set; }
        public Locations LocationToEast {  get; set; }
        public Locations LocationToSouth { get; set; }
        public Locations LocationToWest { get; set; }

        public Locations(int id, string name, string description, Item itemsRequiredToEnter=null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemsRequiredToEnter = itemsRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }
    }
}
