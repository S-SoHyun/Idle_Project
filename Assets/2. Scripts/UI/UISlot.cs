using System;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    CommonItem curItem;                         // 슬롯이 담고 있는 아이템

    private Button equipButton;                 // 슬롯에 달린 버튼 컴포넌트
    [SerializeField] private Image itemIcon;    // 아이템 아이콘
    [SerializeField] private Image equipIcon;   // 장착이 됐다는 것을 표시할 이미지

    public int index;

    public Action setEquipUI;

    private void Start()
    {
        equipButton = GetComponent<Button>();
        equipButton.onClick.AddListener(ItemEquip);
    }

    /// <summary>
    /// 각 슬롯에 인벤토리에 있는 아이템 세팅
    /// </summary>
    /// <param name="item">인벤토리 아이템 리스트에 있는 걸 순서대로 가져옴</param>
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
    /// 아이템 장착
    /// </summary>
    void ItemEquip()
    {
        GameManager.Instance.player.Equip(curItem);
        SetEquipItemUI();
    }

    /// <summary>
    /// 장착 표시 이미지 활성화 / 비활성화
    /// </summary>
    void SetEquipItemUI()
    {
        if (curItem.IsEquipped)
            equipIcon.gameObject.SetActive(true);
        else
            equipIcon.gameObject.SetActive(false);
    }
}