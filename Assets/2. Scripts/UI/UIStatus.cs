using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : UIBase
{
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
    }

    /// <summary>
    /// close 버튼을 누르면 메인 메뉴 창이 나옴
    /// </summary>
    void onClickCloseButton()
    {
        UIManager.Instance.ChangeState(UIState.MainMenu);
    }

    /// <summary>
    /// 인벤토리에서 장착 여부가 바뀌면 새로고침
    /// </summary>
    void EquipChanged()
    {
        SetStatusUI(GameManager.Instance.player);
    }

    /// <summary>
    /// 플레이어의 스탯을 보여줌
    /// </summary>
    public void SetStatusUI(Player player)
    {
        GameManager.Instance.player.EquipChanged -= EquipChanged;
        GameManager.Instance.player.EquipChanged += EquipChanged;

        atkText.text = $"공격력 {player.Atk}";
        defText.text = $"방어력 {player.Def}";
        hpText.text = $"체력 {player.Hp}";
        criticalText.text = $"치명타 {player.Critical}";
    }

    protected override UIState GetUIState()
    {
        return UIState.Status;
    }
}
