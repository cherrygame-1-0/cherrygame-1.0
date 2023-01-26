using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    //float asd = 0.07;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            print("esc");

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        GameObject.Find("player").GetComponent<PlayerMove>().runMoveSpeed = 0.07f;
        GameObject.Find("player").GetComponent<PlayerMove>().MoveSpeed = 11;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        GameObject.Find("player").GetComponent<PlayerMove>().runMoveSpeed = 0;
        GameObject.Find("player").GetComponent<PlayerMove>().MoveSpeed = 0;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Stage1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
