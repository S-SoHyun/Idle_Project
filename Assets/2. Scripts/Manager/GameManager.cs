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
        inventory = new List<Item>() { sword };     // �⺻ ������ = ��

        player = new Player("Skeleton", 1, 35, 40, 100, 25, inventory, "���ڱ� ������� ���� �߰� �� ����� �ذ�.\n������ �ִ� ������ ���� ���� ������ ������.", 0, 10000);
    }

    public void SetUI()
    {
        UIManager.Instance.uiCommon.SetCommonUI(player);
        UIManager.Instance.uiStatus.SetStatusUI(player);
        UIManager.Instance.uiMainMenu.SetMainMenuUI(player);
    }
}
