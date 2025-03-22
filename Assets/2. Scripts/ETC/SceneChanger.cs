using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneChanger : MonoBehaviour
{
    [SerializeField] private Button activeButton;


    void Start()
    {
        activeButton.onClick.AddListener(SceneChange);
    }

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
                break;
            case "StageScene":
                break;
            default:
                break;
        }
    }
}

