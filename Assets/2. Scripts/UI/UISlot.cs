using System;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    Item curItem;

    private Button equipButton;
    [SerializeField] private Image itemIcon;
    [SerializeField] private Image equipIcon;

    public int index;
    private bool equipped;

    public Action setEquipUI;

    private void Start()
    {
        equipButton = GetComponent<Button>();
        equipButton.onClick.AddListener(ItemEquip);
    }

    public void SetItem(Item item)  // 슬롯에 인벤토리에 있는 아이템 넣기
    {
        curItem = item;
        itemIcon.sprite = item.icon;
        SetEquipItemUI();
    }

    public void RefreshUI()
    {
        //item = null;
        equipIcon.gameObject.SetActive(curItem.isEquipped);
    }

    void ItemEquip()
    {
        // 해당 아이템을 갖고와야 됨
        GameManager.Instance.Player.Equip(curItem);
        Debug.Log(GameManager.Instance.Player.Atk);
        SetEquipItemUI();
    }

    void SetEquipItemUI()
    {
        //equipIcon.gameObject.SetActive(!item.isEquipped);
        //item.isEquipped = false;

        if (curItem.isEquipped)
        {
            equipIcon.gameObject.SetActive(true);
        }
        else
        {
            equipIcon.gameObject.SetActive(false);
        }
    }
}