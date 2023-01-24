using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public GameObject NextStageUI;

    public void Show()
    {
        NextStageUI.SetActive(true); // GameOver �˾� â�� ȭ�鿡 ǥ�� ��Ű��
    }

    public void Goal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Stage2");
    }
}
