using System.Collections.Generic;
using UnityEngine;


public enum StatType
{
    Attack,     // 공격력
    Defense,    // 방어력
    Health,     // 체력
    Critical    // 치명타
}

/// <summary>
/// 스탯을 정의하는 클래스
/// </summary>
[System.Serializable]
public class StatEntry
{
    public StatType statType;
    public int statValue;
}


/// <summary>
/// 불변값을 넣어둘 스크립터블 오브젝트
/// </summary>
[CreateAssetMenu(fileName = "New Item", menuName = "Item")]

public class ScriptableItem : ScriptableObject
{
    [Header("Info")]
    public string itemName;
    public Sprite icon;
    public List<StatEntry> stats;
    public int requiredGold;
}

/// <summary>
/// 불변값, 가변값을 같이 넣어둘 아이템 클래스
/// </summary>
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
