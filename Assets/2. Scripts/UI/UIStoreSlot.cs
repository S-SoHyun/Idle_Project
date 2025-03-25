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

    public void SetItem(CommonItem item)  // ���Կ� �κ��丮�� �ִ� ������ �ֱ�
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
        // �÷��̾��� ���� �������� ��庸�� ������ �÷��̾��� �κ��丮�� �߰� �� �÷��̾� -��� , ������ �׳� ����
        // ��� soldPanel Ȱ��ȭ
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
