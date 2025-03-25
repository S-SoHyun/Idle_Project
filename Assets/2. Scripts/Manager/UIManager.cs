using UnityEngine;

public enum UIState
{
    MainMenu,
    Status,
    Inventory,
    Store
}

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private UICommon uiCommon;
    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIStatus uiStatus;
    [SerializeField] private UIInventory uiInventory;
    [SerializeField] private UIStore uiStore;

    public UICommon UiCommon { get; private set; }
    public UIMainMenu UiMainMenu { get; private set; }
    public UIStatus UiStatus { get; private set; }
    public UIInventory UiInventory { get; private set; }
    public UIStore UIStore { get; private set; }

    UIState currentState;


    protected override void Awake()
    {
        base.Awake();

        uiCommon = GetComponentInChildren<UICommon>(true);
        UiCommon = uiCommon;
        uiCommon.Init(this);
        
        uiMainMenu = GetComponentInChildren<UIMainMenu>(true);
        UiMainMenu = uiMainMenu;
        uiMainMenu.Init(this);
        
        uiStatus = GetComponentInChildren<UIStatus>(true);
        UiStatus = uiStatus;
        uiStatus.Init(this);
        
        uiInventory = GetComponentInChildren<UIInventory>(true);
        UiInventory = uiInventory;
        uiInventory.Init(this);
        
        uiStore = GetComponentInChildren<UIStore>(true);
        UIStore = uiStore;
        uiStore.Init(this);

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
}
