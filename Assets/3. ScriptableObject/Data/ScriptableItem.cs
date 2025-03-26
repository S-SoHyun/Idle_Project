using System.Collections.Generic;
using UnityEngine;


public enum StatType
{
    Attack,     // ���ݷ�
    Defense,    // ����
    Health,     // ü��
    Critical    // ġ��Ÿ
}

/// <summary>
/// ������ �����ϴ� Ŭ����
/// </summary>
[System.Serializable]
public class StatEntry
{
    public StatType statType;
    public int statValue;
}


/// <summary>
/// �Һ����� �־�� ��ũ���ͺ� ������Ʈ
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
/// �Һ���, �������� ���� �־�� ������ Ŭ����
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
