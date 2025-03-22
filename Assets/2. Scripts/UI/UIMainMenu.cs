using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : UIBase
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI descText;


    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);
    }

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
