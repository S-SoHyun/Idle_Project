using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : UIBase
{
    [SerializeField] UISlot slotPrefab;
    [SerializeField] Transform slotsContent;
    List<UISlot> slots = new List<UISlot>();
    List<Item> inventoryItems = new List<Item>();

    // temp
    public Item dagger;
    public Item shield;
    public Item hammer;


    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    private void Start()
    {
        // temp
        inventoryItems.Add(dagger);
        inventoryItems.Add(shield);
        inventoryItems.Add(hammer);


        InitInventoryUI();
    }

    private void InitInventoryUI()  
    {
        for (int i = 0; i < inventoryItems.Count ; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotsContent);
            newSlot.SetItem(inventoryItems[i]);
            slots.Add(newSlot);
        }
    }

    protected override UIState GetUIState()
    {
        return UIState.Inventory;
    }
}
