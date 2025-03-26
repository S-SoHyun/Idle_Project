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
    /// close ��ư�� ������ ���� �޴� â�� ����
    /// </summary>
    void onClickCloseButton()
    {
        UIManager.Instance.ChangeState(UIState.MainMenu);
    }

    /// <summary>
    /// �κ��丮���� ���� ���ΰ� �ٲ�� ���ΰ�ħ
    /// </summary>
    void EquipChanged()
    {
        SetStatusUI(GameManager.Instance.player);
    }

    /// <summary>
    /// �÷��̾��� ������ ������
    /// </summary>
    public void SetStatusUI(Player player)
    {
        GameManager.Instance.player.EquipChanged -= EquipChanged;
        GameManager.Instance.player.EquipChanged += EquipChanged;

        atkText.text = $"���ݷ� {player.Atk}";
        defText.text = $"���� {player.Def}";
        hpText.text = $"ü�� {player.Hp}";
        criticalText.text = $"ġ��Ÿ {player.Critical}";
    }

    protected override UIState GetUIState()
    {
        return UIState.Status;
    }
}
