using System.Collections.Generic;
using UnityEngine;

public class UIStore : UIBase
{
    [SerializeField] UIStoreSlot slotPrefab;            // 슬롯 프리팹
    [SerializeField] Transform slotsContent;            // 슬롯 부모 Transform

    List<UIStoreSlot> slots = new List<UIStoreSlot>();  // 슬롯 모아둘 리스트
    List<CommonItem> storeItems;                        // 상점 아이템 리스트

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    /// <summary>
    /// 상점 창 표시
    /// </summary>
    /// <param name="items">GameManager에서 받아온 아이템 리스트</param>
    public void SetStoreUI(List<CommonItem> items)
    {
        storeItems = items;
        Debug.Log(items.Count);
        InitStoreUI();
    }

    /// <summary>
    /// 각 슬롯에 아이템 할당
    /// </summary>
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
