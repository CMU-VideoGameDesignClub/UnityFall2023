using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerClass : MonoBehaviour
{
    //may need to link differently
    public class Stats
    {
        public int health;
        public int damage;
        public int armor;
    }

    public class Items
    {
        public class Trinkets
        {
            public int healthmod;
            public int damagemod;
            public int armormod;
            public int firerate;
            public int fireforce;
            public class effects
            {
                //add more later
            }
        }
        public class Armor
        {
            public int defense;
            public class Helmet
            {

            }
            public class Chest
            {

            }
            public class Legs
            {

            }
            public class Arms
            {

            }
        }
        public string itemName;
        public int itemQuantity;
    }
}
