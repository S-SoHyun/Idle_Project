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

    public void SetCommonUI(Player player)
    {
        goldText.text = player.Gold.ToString();

        // 천단위마다 컴마 붙이기
    }

    void OpenMainMenu()
    {
        UIManager.Instance.ChangeState(UIState.MainMenu);
    }

    void OpenStatus()
    {
        UIManager.Instance.ChangeState(UIState.Status);
    }

    void OpenInventory()
    {
        UIManager.Instance.ChangeState(UIState.Inventory);
    }

    void OpenStore()
    {
        UIManager.Instance.ChangeState(UIState.Store);
    }


    protected override UIState GetUIState()
    {
        return UIState.Status;
    }
}
