using UnityEngine;
using UnityEngine.UI;

public class UIInventory : UIBase
{


    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    protected override UIState GetUIState()
    {
        return UIState.Inventory;
    }
}
