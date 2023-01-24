using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public GameObject NextStageUI;

    public void Show()
    {
        NextStageUI.SetActive(true); // GameOver 팝업 창을 화면에 표시 시키고
    }

    public void Goal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Stage2");
    }
}
