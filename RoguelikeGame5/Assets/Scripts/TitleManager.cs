using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleManager : MonoBehaviour
{
    public GameObject helpPanel;

    public TMP_Text itemCountText;
    public TMP_Text speedText;


    private void Start()
    {
        Debug.Log("SaveManager: " + SaveManager.Instance);

        SaveData data = SaveManager.Instance.LoadData();

        Debug.Log("Data: " + data);

        Debug.Log("ItemText: " + itemCountText);

        Debug.Log("SpeedText: " + speedText);

        itemCountText.text =
            "먹은 아이템 수 : " + data.speedItemCount;

        speedText.text =
            "현재 속도 : " + (1f + data.speedLevel);
    }


    public void GamesStart()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void GameTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }

    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }

    public void ButtonLog()
    {
        Debug.Log("BUTTON CLICKED!");
    }

    public void QuitGame()
    {
        Debug.Log("게임 종료");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}