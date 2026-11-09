using System;
using UnityEngine;

public class LibraryManager : MonoBehaviour
{
    [Serializable]
    public struct ObjectAttributes
    {
        //basic attribute, which set up initial stats for mobs
        public string name;
        public int cost;
        public int coolDown;
        public int hp;
        public int atkDamage;
        public int speed;
        public int range;
        // current attributes : use for in-game attribute
        public int curHp;
    }
}
