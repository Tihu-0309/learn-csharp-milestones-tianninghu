using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Character
{
    public string Name;
    public int Exp = 0;

    public Character()
    {
        Name = "Not Assigned";
    }

    public Character(string name)
    {
        this.Name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", this.Name, this.Exp);
    }

}

// public struct Weapon
// {
//     public string Name;
//     public int Damage;

//     public Weapon(string name, int damage)
//     {
//         Name = name;
//         Damage = damage;

//     }

//     public void PrintWeaponStats()
//     {
//         Debug.LogFormat("Weapon: {0} - {1} DMG", this.Name, this.Damage);

//     }

// }

public class Paladin : Character
{
    public Weapon PrimaryWeapon;

    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.PrimaryWeapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", this.Name, this.PrimaryWeapon.Name);
    }

}