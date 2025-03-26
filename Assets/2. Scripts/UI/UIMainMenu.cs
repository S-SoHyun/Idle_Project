using TMPro;
using UnityEngine;

public class UIMainMenu : UIBase
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI descText;


    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

    /// <summary>
    /// 플레이어의 이름, 레벨, 설명 세팅
    /// </summary>
    public void SetMainMenuUI(Player player)
    {
        nameText.text = player.Name.ToString();
        levelText.text = $"Lv: {player.Level}";
        descText.text = player.Description.ToString();
    }
    protected override UIState GetUIState()
    {
        return UIState.MainMenu;
    }
}
