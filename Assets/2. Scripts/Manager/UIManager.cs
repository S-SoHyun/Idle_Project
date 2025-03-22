using UnityEngine;
using UnityEngine.UI;

public enum UIState
{
    //Common,
    MainMenu,
    Status,
    Inventory,
}

public class UIManager : Singleton<UIManager>
{
    [Header("Init UI")]     // [SerializeField]?
    public UICommon uiCommon;
    public UIMainMenu uiMainMenu;
    public UIStatus uiStatus;
    private UIInventory uiInventory;
    UIState currentState;

    [Header("Buttons")]
    [SerializeField] private Button menuButton;
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;


    protected override void Awake()
    {
        base.Awake();

        uiCommon = GetComponentInChildren<UICommon>(true);
        uiCommon.Init(this);
        uiMainMenu = GetComponentInChildren<UIMainMenu>(true);
        uiMainMenu.Init(this);
        uiStatus = GetComponentInChildren<UIStatus>(true);
        uiStatus.Init(this);
        uiInventory = GetComponentInChildren<UIInventory>(true);
        uiInventory.Init(this);
        
        menuButton.onClick.AddListener(OpenMainMenu);
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);

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
    void OpenMainMenu()
    {
        ChangeState(UIState.MainMenu);
    }

    void OpenStatus()
    {
        ChangeState(UIState.Status);
    }
    
    void OpenInventory()
    {
        ChangeState(UIState.Inventory);
    }

    //void OnCickStage()
    //{
        
    //}
}
