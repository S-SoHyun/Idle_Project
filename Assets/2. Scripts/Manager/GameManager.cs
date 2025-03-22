using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Player player;
    
    
    void Start()
    {
        SetData();
    }

    public void SetData()
    {
        player = new Player("Skeleton", 1, 35, 40, 100, 25, "���ڱ� ������� ���� �߰� �� ����� �ذ�.\n������ �ִ� ������ ���� ���� ������ ������.", 0, 10000);

        UIManager.Instance.uiStatus.SetStatusUI(player);
        UIManager.Instance.uiMainMenu.SetMainMenuUI(player);
    }
}
