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
        player = new Player("Skeleton", 1, 35, 40, 100, 25, "갑자기 평원에서 눈을 뜨게 된 평범한 해골.\n던전에 있는 집으로 가기 위해 모험을 떠난다.", 0, 10000);

        UIManager.Instance.uiStatus.SetStatusUI(player);
        UIManager.Instance.uiMainMenu.SetMainMenuUI(player);
    }
}
