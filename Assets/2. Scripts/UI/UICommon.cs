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
    /// �÷��̾ ���� ��� ǥ��
    /// </summary>
    public void SetCommonUI(Player player)
    {
        GameManager.Instance.player.GoldChanged -= GoldChanged;
        GameManager.Instance.player.GoldChanged += GoldChanged;

        string curGold = player.Gold.ToString("N0");
        goldText.text = curGold;
    }

    /// <summary>
    /// �÷��̾��� ��尡 �ٲ� ������ ���� ǥ��
    /// </summary>
    public void GoldChanged()
    {
        SetCommonUI(GameManager.Instance.player);
    }

    /// <summary>
    /// ���� �޴� â���� ��ȯ
    /// </summary>
    void OpenMainMenu()
    {
        UIManager.Instance.ChangeState(UIState.MainMenu);
    }

    /// <summary>
    /// ���� â���� ��ȯ
    /// </summary>
    void OpenStatus()
    {
        UIManager.Instance.ChangeState(UIState.Status);
    }

    /// <summary>
    /// �κ��丮 â���� ��ȯ
    /// </summary>
    void OpenInventory()
    {
        UIManager.Instance.ChangeState(UIState.Inventory);
    }

    /// <summary>
    /// ���� â���� ��ȯ
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
