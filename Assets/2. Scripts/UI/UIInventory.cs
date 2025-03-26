using System.Collections.Generic;
using UnityEngine;

public class UIInventory : UIBase
{
    [SerializeField] UISlot slotPrefab;         // 슬롯 프리팹
    [SerializeField] Transform slotsContent;    // 슬롯 부모 Transform

    List<UISlot> slots = new List<UISlot>();    // 슬롯 모아둘 리스트
    List<CommonItem> inventoryItems;            // 인벤토리에 있는 아이템 리스트


    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    /// <summary>
    /// 플레이어의 인벤토리를 표시
    /// </summary>
    public void SetInventoryUI(Player player)
    {
        GameManager.Instance.player.InventoryChanged -= InventoryChanged;
        GameManager.Instance.player.InventoryChanged += InventoryChanged;

        inventoryItems = player.Inventory;
        InitInventoryUI();
    }

    /// <summary>
    /// UI에 인벤토리에 있는 아이템 수만큼 아이템 슬롯 채워넣기
    /// </summary>
    void InitInventoryUI()
    {
        for (int i = 0; i < inventoryItems.Count ; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotsContent);
            newSlot.SetItem(inventoryItems[i]);     // 아이템 아이콘, equipIcon 세팅
            slots.Add(newSlot);
        }
    }

    /// <summary>
    /// 인벤토리 아이템이 추가될 때 사용될 메서드
    /// </summary>
    void InventoryChanged()
    {
        AddInventory();
    }

    /// <summary>
    /// 인벤토리 아이템 리스트 마지막에 있는 아이템 세팅
    /// </summary>
    void AddInventory()
    {
        UISlot newSlot = Instantiate(slotPrefab, slotsContent);
        newSlot.SetItem(inventoryItems[inventoryItems.Count - 1]);
        slots.Add(newSlot);
    }

    protected override UIState GetUIState()
    {
        return UIState.Inventory;
    }
}
