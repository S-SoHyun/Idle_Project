using System;
using System.Collections.Generic;

public class Player : Character
{
    public string Description { get; private set; }
    public int Exp { get; private set; }
    public int Gold { get; set; }

    public Player(string name, int level, int atk, int def, int hp, int critical, List<CommonItem> inventory, 
        string description, int exp, int gold) : base(name, level, atk, def, hp, critical, inventory)
    {
        Description = description;
        Exp = exp;
        Gold = gold;
    }

    public Action GoldChanged;
    public Action InventoryChanged;

    public void Buy(CommonItem item)
    {
        Gold -= item.ScriptableItem.requiredGold;
        AddItem(item);
        GoldChanged?.Invoke();
        InventoryChanged?.Invoke();
    }
}
