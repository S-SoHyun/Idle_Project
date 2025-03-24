using System;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UISlot : MonoBehaviour
{
    Item curItem;

    UIInventory uiInventory;

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

    private void OnEnable()
    {

    }

    public void SetItem(Item item)  // 슬롯에 인벤토리에 있는 아이템 넣기
    {
        curItem = item;
        itemIcon.sprite = item.icon;
        SetEquipItemUI(item);
    }

    public void RefreshUI(Item item)
    {
        //item = null;
        equipIcon.gameObject.SetActive(item.isEquipped);
    }

    void ItemEquip()
    {
        // 해당 아이템을 갖고와야 됨


        SetEquipItemUI(curItem);
    }

    void SetEquipItemUI(Item item)
    {
        //equipIcon.gameObject.SetActive(!item.isEquipped);
        //item.isEquipped = false;

        if (item.isEquipped)
        {
            equipIcon.gameObject.SetActive(true);
            item.isEquipped = false;
        }
        else
        {
            equipIcon.gameObject.SetActive(false);
            item.isEquipped = true;
        }
    }
}