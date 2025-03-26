using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStoreSlot : MonoBehaviour
{
    CommonItem curItem;                                 // ������ ��� �ִ� ������

    private Button buyButton;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI statText;
    [SerializeField] private TextMeshProUGUI goldText;

    [SerializeField] private Image itemIcon;
    [SerializeField] private GameObject soldPanel;      // �Ǹŵ����� ������ �г�

    public Action GoldChanged;

    private void Start()
    {
        buyButton = GetComponentInChildren<Button>();
        buyButton.onClick.AddListener(BuyItem);
    }

    /// <summary>
    /// ���Կ� ���� ������ �ֱ�
    /// </summary>
    /// <param name="item"></param>
    public void SetItem(CommonItem item)  
    {
        curItem = item;
        itemIcon.sprite = item.ScriptableItem.icon;
        SetTextUI(item);
    }

    /// <summary>
    /// ������ �̸�, ����, �ʿ� ��� �ؽ�Ʈ �����ִ� �޼���
    /// </summary>
    /// <param name="item"></param>
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

    /// <summary>
    /// ������ ����
    /// </summary>
    void BuyItem()
    {
        Player player = GameManager.Instance.player;
        if (player.Gold >= curItem.ScriptableItem.requiredGold)
        {
            player.Buy(curItem);
            soldPanel.SetActive(true);
        }
        else
            return;
    }
}
