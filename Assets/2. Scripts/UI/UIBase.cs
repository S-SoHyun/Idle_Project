using UnityEngine;

/// <summary>
/// 개별 UI들의 기본이 될 추상 클래스
/// </summary>
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
