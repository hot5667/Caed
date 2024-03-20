using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Speed { get; set; } // 캐릭터의 스피드

    public Character(string name, int health, int attack, int defense, int speed)
    {
        Name = name;
        Health = health;
        Attack = attack;
        Defense = defense;
        Speed = speed;
    }

    public class Player : Character
    {
        public Player(string name, int health, int attack, int defense, int speed)
            : base(name, health, attack, defense, speed)
        {
        }
    }

    public class Monster : Character
    {
        public Monster(string name, int health, int attack, int defense, int speed)
            : base(name, health, attack, defense, speed)
        {
        }
    }

    public class Boss : Character
    {
        public Boss(string name, int health, int attack, int defense, int speed)
            : base(name, health, attack, defense, speed)
        {
        }


        public virtual void PerformAction()
        {
            // 액션을 수행하는 로직을 각 하위 클래스에서 구현
        }
    }
}
