using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    //float asd = 0.07;
    public GameObject pauseMenuUI;
    public GameObject num3;
    public GameObject num2;
    public GameObject num1;

    private void Start()
    {
        Time.timeScale = 0f;
        StartCoroutine(ShowNumber3());
    }
    //void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        print("esc");

    //        if (GameIsPaused)
    //        {
    //            //Resume();
    //            CallResume();
    //        }
    //        else
    //        {
    //            Pause();
    //        }
    //    }
    //}

    public void ESC()
    {
        if (GameIsPaused)
        {
            //Resume();
            CallResume();
        }
        else
        {
            Pause();
        }
    }

    public void CallResume()
    {
        StartCoroutine(ShowNumber3());
    }
    IEnumerator Resume()
    {
        
        Time.timeScale = 1f;
        GameIsPaused = false;

        GameObject.Find("player").GetComponent<PlayerMove>().runMoveSpeed = 8f;
        GameObject.Find("player").GetComponent<PlayerMove>().MoveSpeed = 11;

        yield return null;
    }

    IEnumerator ShowNumber3()
    {
        Debug.Log("3");
        pauseMenuUI.SetActive(false);
        num3.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
        num3.SetActive(false);
        StartCoroutine(ShowNumber2());
    }

    IEnumerator ShowNumber2()
    {
        Debug.Log("2");
        num2.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
        num2.SetActive(false);

        StartCoroutine(ShowNumber1());
    }

    IEnumerator ShowNumber1()
    {
        Debug.Log("1");
        num1.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
        num1.SetActive(false);
        StartCoroutine(Resume());
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
