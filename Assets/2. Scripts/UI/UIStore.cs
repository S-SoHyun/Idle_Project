using System.Collections.Generic;
using UnityEngine;

public class UIStore : UIBase
{
    [SerializeField] UIStoreSlot slotPrefab;            // ���� ������
    [SerializeField] Transform slotsContent;            // ���� �θ� Transform

    List<UIStoreSlot> slots = new List<UIStoreSlot>();  // ���� ��Ƶ� ����Ʈ
    List<CommonItem> storeItems;                        // ���� ������ ����Ʈ

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    /// <summary>
    /// ���� â ǥ��
    /// </summary>
    /// <param name="items">GameManager���� �޾ƿ� ������ ����Ʈ</param>
    public void SetStoreUI(List<CommonItem> items)
    {
        storeItems = items;
        Debug.Log(items.Count);
        InitStoreUI();
    }

    /// <summary>
    /// �� ���Կ� ������ �Ҵ�
    /// </summary>
    void InitStoreUI()
    {
        for (int i = 0; i < storeItems.Count; i++)
        {
            UIStoreSlot newSlot = Instantiate(slotPrefab, slotsContent);
            newSlot.SetItem(storeItems[i]);     // ������ ������, equipIcon ����
            slots.Add(newSlot);
        }
    }

    protected override UIState GetUIState()
    {
        return UIState.Store;
    }
}
