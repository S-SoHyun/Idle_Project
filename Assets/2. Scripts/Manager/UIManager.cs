using UnityEngine;
using UnityEngine.UI;

public enum UIState
{
    MainMenu,
    Status,
    Inventory,
}

public class UIManager : Singleton<UIManager>
{
    [Header("Init UI")]
    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIStatus uiStatus;
    [SerializeField] private UIInventory uiInventory;
    UIState currentState;

    [Header("Buttons")]
    [SerializeField] private Button menuButton;
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;


    void Start()
    {
        uiMainMenu = GetComponentInChildren<UIMainMenu>(true);
        uiMainMenu.Init(this);
        uiStatus = GetComponentInChildren<UIStatus>(true);
        uiStatus.Init(this);
        uiInventory = GetComponentInChildren<UIInventory>(true);
        uiInventory.Init(this);
        
        menuButton.onClick.AddListener(OnClickMainMenu);
        statusButton.onClick.AddListener(OnClickStatus);
        inventoryButton.onClick.AddListener(OnClickInventory);
    
        ChangeState(UIState.MainMenu);
    }

    public void ChangeState(UIState state)
    {
        currentState = state;
        uiMainMenu.SetUIActive(currentState);
        uiStatus.SetUIActive(currentState);
        uiInventory.SetUIActive(currentState);
    }

    // ButtonClick
    void OnClickMainMenu()
    {
        ChangeState(UIState.MainMenu);
    }

    void OnClickStatus()
    {
        ChangeState(UIState.Status);
    }
    
    void OnClickInventory()
    {
        ChangeState(UIState.Inventory);
    }

    //void OnCickStage()
    //{
        
    //}
}
