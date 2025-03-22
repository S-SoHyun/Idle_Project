using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    public Player player;
    public Player Player
    {
        get { return player; }
        set { player = value; }
    }

    public PlayerController controller;
    public PlayerCondition condition;


    private void Start()
    {
        controller = GetComponent<PlayerController>();
        condition = GetComponent<PlayerCondition>();
    }
}
