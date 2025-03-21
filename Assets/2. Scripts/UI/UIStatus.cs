using UnityEngine;
using UnityEngine.UI;

public class UIStatus : UIBase
{
    [SerializeField] private Button closeButton;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
        closeButton.onClick.AddListener(onClickCloseButton);
    }

    void onClickCloseButton()
    {
        UIManager.Instance.ChangeState(UIState.MainMenu);
    }

    protected override UIState GetUIState()
    {
        return UIState.Status;
    }
}
