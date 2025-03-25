using System.Collections.Generic;
using UnityEngine;


public enum StatType
{
    Attack,
    Defense,
    Health,
    Critical
}

[System.Serializable]
public class StatEntry
{
    public StatType statType;
    public int statValue;
}


//�Һ��� �־�� SO
[CreateAssetMenu(fileName = "New Item", menuName = "Item")]

public class ScriptableItem : ScriptableObject
{
    [Header("Info")]
    public string itemName;
    public Sprite icon;
    public List<StatEntry> stats;
}

// �Һ��� + ������ �־�� ������ Ŭ����
public class CommonItem
{
    public ScriptableItem ScriptableItem { get; private set; }
    public bool IsEquipped;

    public CommonItem(ScriptableItem item)
    {
        ScriptableItem = item;
        IsEquipped = false;
    }
}
