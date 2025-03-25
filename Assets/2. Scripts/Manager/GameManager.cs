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
        string characterDescription = "갑자기 평원에서 눈을 뜨게 된 평범한 해골.\n던전에 있는 집으로 가기 위해 모험을 떠난다.";    // 캐릭터 설명
        inventory = new List<CommonItem>() { sword };                                                                              // 기본 아이템 = 검

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
