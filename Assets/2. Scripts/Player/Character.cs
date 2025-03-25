using System;
using System.Collections.Generic;

public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }

    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Hp { get; private set; }
    public int Critical { get; private set; }

    public List<Item> Inventory { get; private set; }

    public Action EquipChanged;


    public Character(string name, int level, int atk, int def, int hp, int critical, List<Item> inventory)
    {
        Name = name;
        Level = level;

        Atk = atk;
        Def = def;
        Hp = hp;
        Critical = critical;

        Inventory = inventory;
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public Action addItem;

    public void Equip(Item item)
    {
        if (item.isEquipped)
        {
            UnEquip(item);
        }
        else
        {
            switch (item.stats[0].statType)
            {
                case StatType.Attack:
                    Atk += item.stats[0].statValue;
                    break;
                case StatType.Defense:
                    Def += item.stats[0].statValue;
                    break;
                default:
                    break;
            }
            item.isEquipped = true;
            EquipChanged?.Invoke();
        }
    }

    public void UnEquip(Item item)
    {
        switch (item.stats[0].statType)
        {
            case StatType.Attack:
                Atk -= item.stats[0].statValue;
                break;
            case StatType.Defense:
                Def -= item.stats[0].statValue;
                break;
        }

        item.isEquipped = false;
        EquipChanged?.Invoke();
    }
}
