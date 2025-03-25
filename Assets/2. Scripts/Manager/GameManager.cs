using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Player Player { get; private set; }

    List<Item> inventory;
    
    [SerializeField] Item sword;

    // temp
    [SerializeField] Item scythe;
    [SerializeField] Item shield;
    [SerializeField] Item dagger;
    [SerializeField] Item hammer;


    protected override void Awake()
    {
        base.Awake();

        SetData();
    }

    void Start()
    {

    }

    void SetData()
    {
        inventory = new List<Item>() { sword, scythe, shield, dagger, hammer };     // 기본 아이템 = 검
        Player = new Player("Skeleton", 1, 35, 40, 100, 25, inventory, 
            "갑자기 평원에서 눈을 뜨게 된 평범한 해골.\n던전에 있는 집으로 가기 위해 모험을 떠난다.", 0, 10000);

        SetUI();
    }

    void SetUI()
    {
        UIManager.Instance.UiCommon.SetCommonUI(Player);
        UIManager.Instance.UiStatus.SetStatusUI(Player);
        UIManager.Instance.UiMainMenu.SetMainMenuUI(Player);
    }
}
