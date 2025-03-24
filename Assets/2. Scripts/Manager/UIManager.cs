using UnityEngine;
using UnityEngine.UI;

public enum UIState
{
    //Common,
    MainMenu,
    Status,
    Inventory,
    Store
}

public class UIManager : Singleton<UIManager>
{
    [Header("Init UI")]     // [SerializeField]?
    public UICommon uiCommon;
    public UIMainMenu uiMainMenu;
    public UIStatus uiStatus;
    public UIInventory uiInventory;
    public UIStore uiStore;
    UIState currentState;

    [Header("Buttons")]
    [SerializeField] private Button menuButton;
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    [SerializeField] private Button storeButton;

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
        uiStore = GetComponentInChildren<UIStore>(true);
        uiStore.Init(this);
        
        menuButton.onClick.AddListener(OpenMainMenu);
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
        storeButton.onClick.AddListener(OpenStore);

        ChangeState(UIState.MainMenu);
    }

    public void ChangeState(UIState state)
    {
        currentState = state;
        uiMainMenu.SetUIActive(currentState);
        uiStatus.SetUIActive(currentState);
        uiInventory.SetUIActive(currentState);
        uiStore.SetUIActive(currentState);
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

    void OpenStore()
    {
        ChangeState(UIState.Store);
    }

    //void OnCickStage()
    //{
        
    //}
}
