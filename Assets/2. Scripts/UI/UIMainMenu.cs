using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button menuButton;
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;



    void Start()
    {
        menuButton.onClick.AddListener(OpenMainMenu);
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    void Update()
    {
        
    }

    void OpenMainMenu()
    {

    }

    void OpenStatus()
    {

    }

    void OpenInventory()
    {

    }

}
