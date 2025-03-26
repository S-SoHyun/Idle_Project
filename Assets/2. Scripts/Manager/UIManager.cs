using UnityEngine;

public enum UIState
{
    MainMenu,       // 메인메뉴창
    Status,         // 상태창
    Inventory,      // 인벤토리창
    Store           // 상점창
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
    public UIStore UiStore { get; private set; }

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
        UiStore = uiStore;
        uiStore.Init(this);

        ChangeState(UIState.MainMenu);      // 시작 = 메인메뉴창
    }

    /// <summary>
    /// UI 활성화 여부 바꾸는 메서드
    /// </summary>
    public void ChangeState(UIState state)
    {
        currentState = state;
        uiMainMenu.SetUIActive(currentState);
        uiStatus.SetUIActive(currentState);
        uiInventory.SetUIActive(currentState);
        uiStore.SetUIActive(currentState);
    }
}
