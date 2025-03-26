using System.Collections.Generic;
using UnityEngine;

public class UIInventory : UIBase
{
    [SerializeField] UISlot slotPrefab;         // ���� ������
    [SerializeField] Transform slotsContent;    // ���� �θ� Transform

    List<UISlot> slots = new List<UISlot>();    // ���� ��Ƶ� ����Ʈ
    List<CommonItem> inventoryItems;            // �κ��丮�� �ִ� ������ ����Ʈ


    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    /// <summary>
    /// �÷��̾��� �κ��丮�� ǥ��
    /// </summary>
    public void SetInventoryUI(Player player)
    {
        GameManager.Instance.player.InventoryChanged -= InventoryChanged;
        GameManager.Instance.player.InventoryChanged += InventoryChanged;

        inventoryItems = player.Inventory;
        InitInventoryUI();
    }

    /// <summary>
    /// UI�� �κ��丮�� �ִ� ������ ����ŭ ������ ���� ä���ֱ�
    /// </summary>
    void InitInventoryUI()
    {
        for (int i = 0; i < inventoryItems.Count ; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotsContent);
            newSlot.SetItem(inventoryItems[i]);     // ������ ������, equipIcon ����
            slots.Add(newSlot);
        }
    }

    /// <summary>
    /// �κ��丮 �������� �߰��� �� ���� �޼���
    /// </summary>
    void InventoryChanged()
    {
        AddInventory();
    }

    /// <summary>
    /// �κ��丮 ������ ����Ʈ �������� �ִ� ������ ����
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
