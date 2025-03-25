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
        GameManager.Instance.player.InventoryChanged += InventoryChanged;

        inventoryItems = player.Inventory;
        InitInventoryUI();
    }

    private void InitInventoryUI()
    {
        for (int i = 0; i < inventoryItems.Count ; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotsContent);
            newSlot.SetItem(inventoryItems[i]);     // ������ ������, equipIcon ����
            slots.Add(newSlot);
        }
    }

    void InventoryChanged()
    {
        AddInventory();
    }

    void AddInventory()     // ����Ʈ �������� �ִ� ������ ����
    {
        UISlot newSlot = Instantiate(slotPrefab, slotsContent);
        newSlot.SetItem(inventoryItems[inventoryItems.Count-1]);     // ������ ������, equipIcon ����
        slots.Add(newSlot);
    }

    protected override UIState GetUIState()
    {
        return UIState.Inventory;
    }
}
