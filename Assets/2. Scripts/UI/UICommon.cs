using UnityEngine;
using TMPro;

public class UICommon : UIBase
{
    Player player;

    [SerializeField] private TextMeshProUGUI goldText;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    void onClickCloseButton()
    {
        UIManager.Instance.ChangeState(UIState.MainMenu);
    }

    public void SetCommonUI(Player player)
    {
        goldText.text = player.Gold.ToString();
        // õ�������� �ĸ� ���̱�
    }

    protected override UIState GetUIState()
    {
        return UIState.Status;
    }
}
