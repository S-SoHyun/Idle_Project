using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : Singleton<GameManager>
{
    public Player player;
    private List<Item> inventory;
    [SerializeField] Item sword;


    protected override void Awake()
    {
        base.Awake();

        SetData();
        SetUI();
    }

    void Start()
    {

    }

    public void SetData()
    {
        inventory = new List<Item>() { sword };     // 기본 아이템 = 검

        player = new Player("Skeleton", 1, 35, 40, 100, 25, inventory, "갑자기 평원에서 눈을 뜨게 된 평범한 해골.\n던전에 있는 집으로 가기 위해 모험을 떠난다.", 0, 10000);
    }

    public void SetUI()
    {
        UIManager.Instance.uiCommon.SetCommonUI(player);
        UIManager.Instance.uiStatus.SetStatusUI(player);
        UIManager.Instance.uiMainMenu.SetMainMenuUI(player);
    }
}
