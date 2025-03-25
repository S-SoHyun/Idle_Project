using System;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    CommonItem curItem;

    private Button equipButton;
    [SerializeField] private Image itemIcon;
    [SerializeField] private Image equipIcon;

    public int index;

    public Action setEquipUI;

    private void Start()
    {
        equipButton = GetComponent<Button>();
        equipButton.onClick.AddListener(ItemEquip);
    }

    public void SetItem(CommonItem item)  // 슬롯에 인벤토리에 있는 아이템 넣기
    {
        curItem = item;

        if (item == null)
        {
            Debug.Log("item is null");
        }
        else
        {
            itemIcon.sprite = item.ScriptableItem.icon;
        }

        SetEquipItemUI();
    }

    public void RefreshUI()
    {
        //item = null;
        equipIcon.gameObject.SetActive(curItem.IsEquipped);
    }

    void ItemEquip()
    {
        GameManager.Instance.player.Equip(curItem);
        Debug.Log(GameManager.Instance.player.Atk);
        SetEquipItemUI();
    }

    void SetEquipItemUI()
    {
        //equipIcon.gameObject.SetActive(!item.isEquipped);
        //item.isEquipped = false;

        if (curItem.IsEquipped)
        {
            equipIcon.gameObject.SetActive(true);
        }
        else
        {
            equipIcon.gameObject.SetActive(false);
        }
    }
}