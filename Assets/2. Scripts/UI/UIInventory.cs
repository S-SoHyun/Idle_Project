using System.Collections.Generic;
using UnityEngine;

public class UIInventory : UIBase
{
    [SerializeField] UISlot slotPrefab;
    [SerializeField] Transform slotsContent;

    List<UISlot> slots = new List<UISlot>();
    List<CommonItem> inventoryItems;


    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    public void SetInventoryUI(Player player)
    {
        inventoryItems = player.Inventory;
        InitInventoryUI();
    }

    private void InitInventoryUI()  
    {
        for (int i = 0; i < inventoryItems.Count ; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotsContent);
            newSlot.SetItem(inventoryItems[i]);     // 아이템 아이콘, equipIcon 세팅
            slots.Add(newSlot);
        }
    }

    protected override UIState GetUIState()
    {
        return UIState.Inventory;
    }
}
