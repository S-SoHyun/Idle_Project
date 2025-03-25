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
        inventory = new List<Item>() { sword, scythe, shield, dagger, hammer };     // �⺻ ������ = ��
        Player = new Player("Skeleton", 1, 35, 40, 100, 25, inventory, 
            "���ڱ� ������� ���� �߰� �� ����� �ذ�.\n������ �ִ� ������ ���� ���� ������ ������.", 0, 10000);

        SetUI();
    }

    void SetUI()
    {
        UIManager.Instance.UiCommon.SetCommonUI(Player);
        UIManager.Instance.UiStatus.SetStatusUI(Player);
        UIManager.Instance.UiMainMenu.SetMainMenuUI(Player);
    }
}
