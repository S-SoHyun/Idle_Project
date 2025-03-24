using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : UIBase
{
    Player player;

    [SerializeField] private TextMeshProUGUI atkText;
    [SerializeField] private TextMeshProUGUI defText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI criticalText;

    [SerializeField] private Button closeButton;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    private void Start()
    {
        closeButton.onClick.AddListener(onClickCloseButton);
        GameManager.Instance.player.EquipChanged += EquipChanged;
    }

    private void OnEnable()
    {
        //SetStatusUI(player);
    }

    void onClickCloseButton()
    {
        UIManager.Instance.ChangeState(UIState.MainMenu);
    }

    void EquipChanged()
    {
        player = GameManager.Instance.player;
        SetStatusUI(player);
    }

    public void SetStatusUI(Player player)
    {
        atkText.text = $"공격력\n{player.Atk}";
        defText.text = $"방어력\n{player.Def}";
        hpText.text = $"체력\n{player.Hp}";
        criticalText.text = $"치명타\n{player.Critical}";
    }

    protected override UIState GetUIState()
    {
        return UIState.Status;
    }
}
