using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Player player;
    List<Item> inventory;
    [SerializeField] Item sword;


    protected override void Awake()
    {
        base.Awake();

        SetData();
    }

    void Start()
    {
        SetUI();
    }

    void SetData()
    {
        inventory = new List<Item>() { sword };     // �⺻ ������ = ��
        player = new Player("Skeleton", 1, 35, 40, 100, 25, inventory, 
            "���ڱ� ������� ���� �߰� �� ����� �ذ�.\n������ �ִ� ������ ���� ���� ������ ������.", 0, 10000);
    }

    void SetUI()
    {
        UIManager.Instance.UiCommon.SetCommonUI(player);
        UIManager.Instance.UiStatus.SetStatusUI(player);
        UIManager.Instance.UiMainMenu.SetMainMenuUI(player);
    }
}
