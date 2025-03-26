using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneChanger : MonoBehaviour
{
    // 현재 연결된 버튼
    [SerializeField] private Button activeButton;

    void Start()
    {
        activeButton.onClick.AddListener(SceneChange);
    }

    /// <summary>
    /// 현재 Scene에 따라 작동을 달리하는 메서드
    /// </summary>
    public void SceneChange()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        
        switch (activeScene)
        {
            case "StartScene":
                SceneManager.LoadScene("MainScene");
                break;
            case "MainScene":
                SceneManager.LoadScene("StageScene");
                UIManager.Instance.UiCommon.gameObject.SetActive(false);
                UIManager.Instance.UiMainMenu.gameObject.SetActive(false);
                UIManager.Instance.UiStatus.gameObject.SetActive(false);
                break;
            case "StageScene":
                break;
            default:
                break;
        }
    }
}

