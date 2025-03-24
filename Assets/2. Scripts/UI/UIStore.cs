using UnityEngine;

public class UIStore : UIBase
{
    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    protected override UIState GetUIState()
    {
        return UIState.Store;
    }
}
