using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UICommon : UIBase
{
    [SerializeField] private TextMeshProUGUI goldText;

    [Header("Buttons")]
    [SerializeField] private Button menuButton;
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    [SerializeField] private Button storeButton;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    private void Start()
    {
        menuButton.onClick.AddListener(OpenMainMenu);
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
        storeButton.onClick.AddListener(OpenStore);
    }


    /// <summary>
    /// 플레이어가 가진 골드 표시
    /// </summary>
    public void SetCommonUI(Player player)
    {
        GameManager.Instance.player.GoldChanged -= GoldChanged;
        GameManager.Instance.player.GoldChanged += GoldChanged;

        string curGold = player.Gold.ToString("N0");
        goldText.text = curGold;
    }

    /// <summary>
    /// 플레이어의 골드가 바뀔 때마다 새로 표시
    /// </summary>
    public void GoldChanged()
    {
        SetCommonUI(GameManager.Instance.player);
    }

    /// <summary>
    /// 메인 메뉴 창으로 전환
    /// </summary>
    void OpenMainMenu()
    {
        UIManager.Instance.ChangeState(UIState.MainMenu);
    }

    /// <summary>
    /// 상태 창으로 전환
    /// </summary>
    void OpenStatus()
    {
        UIManager.Instance.ChangeState(UIState.Status);
    }

    /// <summary>
    /// 인벤토리 창으로 전환
    /// </summary>
    void OpenInventory()
    {
        UIManager.Instance.ChangeState(UIState.Inventory);
    }

    /// <summary>
    /// 상점 창으로 전환
    /// </summary>
    void OpenStore()
    {
        UIManager.Instance.ChangeState(UIState.Store);
    }
    protected override UIState GetUIState()
    {
        return UIState.Status;
    }
}
