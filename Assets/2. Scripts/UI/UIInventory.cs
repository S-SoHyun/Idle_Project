using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : UIBase
{
    [SerializeField] UISlot slotPrefab;
    [SerializeField] Transform slotsContent;
    List<UISlot> slots = new List<UISlot>();
    List<Item> inventoryItems;


    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    private void Start()
    {
        inventoryItems = GameManager.Instance.player.Inventory;

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
