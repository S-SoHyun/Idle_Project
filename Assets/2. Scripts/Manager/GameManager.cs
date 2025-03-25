using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    // PLAYER
    public Player player { get; private set; }
    List<CommonItem> inventory;

    //ITEM
    CommonItem sword;
    CommonItem axe;
    CommonItem scythe;
    CommonItem shield;
    CommonItem dagger;
    CommonItem hammer;
        
    [SerializeField] ScriptableItem swordSo;
    [SerializeField] ScriptableItem axeSo;
    [SerializeField] ScriptableItem scytheSo;
    [SerializeField] ScriptableItem shieldSo;
    [SerializeField] ScriptableItem daggerSo;
    [SerializeField] ScriptableItem hammerSo;
    List<CommonItem> storeItems;

    protected override void Awake()
    {
        base.Awake();
        SetItemData();
        SetPlayerData();
        SetUI();
    }

    void SetPlayerData()
    {
        string characterDescription = "���ڱ� ������� ���� �߰� �� ����� �ذ�.\n������ �ִ� ������ ���� ���� ������ ������.";    // ĳ���� ����
        inventory = new List<CommonItem>() { sword };                                                                              // �⺻ ������ = ��

        player = new Player("Skeleton", 1, 35, 40, 100, 25, inventory, characterDescription, 0, 10000);
        Debug.Log(player.Inventory.Count);
    }

    void SetItemData()
    {
        sword = new CommonItem(swordSo);
        axe = new CommonItem(axeSo);
        scythe = new CommonItem(scytheSo);
        shield= new CommonItem(shieldSo);
        dagger = new CommonItem(daggerSo);
        hammer = new CommonItem(hammerSo);

        storeItems = new List<CommonItem>() { axe, scythe, shield, dagger, hammer };
    }

    void SetUI()
    {
        UIManager.Instance.UiCommon.SetCommonUI(player);
        UIManager.Instance.UiStatus.SetStatusUI(player);
        UIManager.Instance.UiMainMenu.SetMainMenuUI(player);
        UIManager.Instance.UiInventory.SetInventoryUI(player);
        UIManager.Instance.UIStore.SetStoreUI(storeItems);
    }
}
