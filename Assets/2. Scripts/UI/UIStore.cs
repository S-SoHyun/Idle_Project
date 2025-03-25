using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStore : UIBase
{
    [SerializeField] UIStoreSlot slotPrefab;
    [SerializeField] Transform slotsContent;

    List<UIStoreSlot> slots = new List<UIStoreSlot>();
    List<CommonItem> storeItems;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    public void SetStoreUI(List<CommonItem> items)
    {
        storeItems = items;
        Debug.Log(items.Count);
        InitStoreUI();
    }

    void InitStoreUI()
    {
        for (int i = 0; i < storeItems.Count; i++)
        {
            UIStoreSlot newSlot = Instantiate(slotPrefab, slotsContent);
            newSlot.SetItem(storeItems[i]);     // 아이템 아이콘, equipIcon 세팅
            slots.Add(newSlot);
        }
    }

    protected override UIState GetUIState()
    {
        return UIState.Store;
    }
}
