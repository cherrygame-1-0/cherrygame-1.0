using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject GameOverMenuUI;

    public void Show()
    {
        GameOverMenuUI.SetActive(true); // GameOver 팝업 창을 화면에 표시 시키고
    }

    public void OnClick_Retry() // '재도전' 버튼을 클릭하며 호출 되어질 함수
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Stage1"); // SceneManager의 LoadScene 함수를 사용하여! 현재 신 'GameScene'을 다시 불러오도록 시킨다.
                                             // 같은 신을 다시 불러오면 게임이 재시작 된다.
    }

    public void Menu()
    {
        Debug.Log("Back To Menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
