using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {

        this.name = name;
        this.damage = damage;

    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon name: {0} - {1}", this.name, this.damage);
    }
}

public class Character
{

    public string name;
    public int exp = 5;

    public Character()
    {
        name = "Jean Carlo";
    }

    public Character(string name)
    {

        this.name = name;

    }

    public void PrintCharacterStatus()
    {

        Debug.LogFormat("Character name: {0} - {1} experience", this.name, this.exp);
    }

    private void Reset()
    {

        this.name = "";
        this.exp = 0;
    }

}


public class Paladin : Character
{
    public Weapon weapon;

    public Paladin (string name, Weapon weapon) : base(name)
    {
        this.name = name;
        this.weapon = weapon;

    }


}

public class Archer : Character
{
    Weapon arch;

    public Archer (string name, Weapon arch): base(name)
    {

        this.name = name;
        this.arch = arch;

    }

}

public class Magician : Character
{

    Weapon staff;

    public Magician(string name) : base(name)
    {

        this.name = name;
        this.staff = new Weapon("Magic Staff", 50);


    }

}

