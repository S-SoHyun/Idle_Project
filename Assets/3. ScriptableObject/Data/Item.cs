using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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


[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public List<StatEntry> stats;
}
