using System;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    CommonItem curItem;                         // ������ ��� �ִ� ������

    private Button equipButton;                 // ���Կ� �޸� ��ư ������Ʈ
    [SerializeField] private Image itemIcon;    // ������ ������
    [SerializeField] private Image equipIcon;   // ������ �ƴٴ� ���� ǥ���� �̹���

    public int index;

    public Action setEquipUI;

    private void Start()
    {
        equipButton = GetComponent<Button>();
        equipButton.onClick.AddListener(ItemEquip);
    }

    /// <summary>
    /// �� ���Կ� �κ��丮�� �ִ� ������ ����
    /// </summary>
    /// <param name="item">�κ��丮 ������ ����Ʈ�� �ִ� �� ������� ������</param>
    public void SetItem(CommonItem item)
    {
        curItem = item;
        itemIcon.sprite = item.ScriptableItem.icon;
        SetEquipItemUI();
    }

    //public void RefreshUI(CommonItem item)
    //{
    //    item = null;
    //}

    /// <summary>
    /// ������ ����
    /// </summary>
    void ItemEquip()
    {
        GameManager.Instance.player.Equip(curItem);
        SetEquipItemUI();
    }

    /// <summary>
    /// ���� ǥ�� �̹��� Ȱ��ȭ / ��Ȱ��ȭ
    /// </summary>
    void SetEquipItemUI()
    {
        if (curItem.IsEquipped)
            equipIcon.gameObject.SetActive(true);
        else
            equipIcon.gameObject.SetActive(false);
    }
}