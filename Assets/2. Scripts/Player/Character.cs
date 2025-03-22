using UnityEngine;

public class Character
{
    // INFO
    private string name;
    private int level;

    // STAT
    private int atk;
    private int def;
    private int hp;
    private int critical;


    // PROPERTY
    public string Name { get; private set; }
    public int Level { get; private set; }
    
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Hp { get; private set; }
    public int Critical { get; private set; }


    // CONSTRUCTOR
    public Character(string name, int level, int atk, int def, int hp, int critical)
    {
        Name = name;
        Level = level;

        Atk = atk;
        Def = def;
        Hp = hp;
        Critical = critical;
    }
}

