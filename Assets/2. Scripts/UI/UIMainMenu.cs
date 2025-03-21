using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : UIBase
{
    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    protected override UIState GetUIState()
    {
        return UIState.MainMenu;
    }
}
