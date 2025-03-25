using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStoreSlot : MonoBehaviour
{
    CommonItem curItem;

    private Button buyButton;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI statText;
    [SerializeField] private TextMeshProUGUI goldText;

    [SerializeField] private Image itemIcon;
    [SerializeField] private GameObject soldPanel;

    List<CommonItem> storeItems;

    public Action GoldChanged;

    private void Start()
    {
        buyButton = GetComponentInChildren<Button>();
        buyButton.onClick.AddListener(BuyItem);
    }

    public void SetItem(CommonItem item)  // 슬롯에 인벤토리에 있는 아이템 넣기
    {
        curItem = item;
        itemIcon.sprite = item.ScriptableItem.icon;
        SetTextUI(item);
    }

    void SetTextUI(CommonItem item)
    {
        List<StatEntry> stats = item.ScriptableItem.stats;
        string text = "";

        for (int i = 0; i < stats.Count ; i++ )
        {
            text += $"{stats[i].statType} +{stats[i].statValue} ";
        }

        nameText.text = item.ScriptableItem.itemName;
        statText.text = text;
        goldText.text = $"$ {item.ScriptableItem.requiredGold.ToString("N0")}";
    }

    void BuyItem()
    {
        Player player = GameManager.Instance.player;
        // 플레이어의 돈이 아이템의 골드보다 높으면 플레이어의 인벤토리에 추가 후 플레이어 -골드 , 없으면 그냥 리턴
        // 사면 soldPanel 활성화
        if (player.Gold >= curItem.ScriptableItem.requiredGold)
        {
            player.Buy(curItem);
            soldPanel.SetActive(true);
        }
        else
        {
            return;
        }
    }
}
