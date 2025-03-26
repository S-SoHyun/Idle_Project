using System;
using System.Collections.Generic;


/// <summary>
/// 공통 캐릭터 클래스
/// </summary>
public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }

    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Hp { get; private set; }
    public int Critical { get; private set; }

    public List<CommonItem> Inventory { get; private set; }

    public Action EquipChanged;

    public Character(string name, int level, int atk, int def, int hp, int critical, List<CommonItem> inventory)
    {
        Name = name;
        Level = level;

        Atk = atk;
        Def = def;
        Hp = hp;
        Critical = critical;

        Inventory = inventory;
    }

    /// <summary>
    /// 인벤토리에 아이템 추가
    /// </summary>
    public void AddItem(CommonItem item)
    {
        Inventory.Add(item);
    }

    /// <summary>
    /// 아이템 장착
    /// </summary>
    /// <param name="item"></param>
    public void Equip(CommonItem item)
    {
        if (item.IsEquipped)
        {
            UnEquip(item);
        }
        else
        {   // stats List 순회. 각 스탯 type에 따라 플레이어 스탯에 value 추가
            foreach (StatEntry stat in item.ScriptableItem.stats)
            {
                switch (stat.statType)
                {
                    case StatType.Attack:
                        Atk += stat.statValue;
                        break;
                    case StatType.Defense:
                        Def += stat.statValue;
                        break;
                    case StatType.Health:
                        Hp += stat.statValue;
                        break;
                    case StatType.Critical:
                        Critical += stat.statValue;
                        break;
                }
            }
            item.IsEquipped = true;
            EquipChanged?.Invoke();
        }
    }
    /// <summary>
    /// 아이템 장착 해제
    /// </summary>
    public void UnEquip(CommonItem item)
    {
        foreach (StatEntry stat in item.ScriptableItem.stats)
        {
            switch (stat.statType)
            {
                case StatType.Attack:
                    Atk -= stat.statValue;
                    break;
                case StatType.Defense:
                    Def -= stat.statValue;
                    break;
                case StatType.Health:
                    Hp -= stat.statValue;
                    break;
                case StatType.Critical:
                    Critical -= stat.statValue;
                    break;
            }
        }
        item.IsEquipped = false;
        EquipChanged?.Invoke();
    }
}
