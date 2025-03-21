using System.Collections;
using UnityEditor.Timeline;
using UnityEngine;

public abstract class UIBase : MonoBehaviour
{
    protected UIManager uiManager;

    public virtual void Init(UIManager uIManager)
    {
        this.uiManager = uIManager;
    }

    protected abstract UIState GetUIState();
    public void SetUIActive(UIState state)
    {
        this.gameObject.SetActive(GetUIState() == state);
    }

}
