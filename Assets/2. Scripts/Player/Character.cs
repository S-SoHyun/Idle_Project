using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // INFO
    private string name;
    private int level;
    private string description;
    private int gold;

    // STAT
    private int atk;
    private int def;
    private int hp;
    private int critical;

    // PROPERTY
    public string Name { get; set; }
    public int Level { get; set; }
    public string Description { get; set; }
    public int Gold { get; set; }

    public int Atk { get; set; }
    public int Def { get; set; }
    public int Hp { get; set; }
    public int Critical { get; set; }


    // CONSTRUCTOR
    public Character(string name, int level, string description, int gold, int atk, int def, int hp, int critical)
    {
        name = Name;
        level = Level;
        description = Description;
        gold = Gold;

        atk = Atk;
        def = Def;
        hp = Hp;
        critical = Critical;
    }
}
