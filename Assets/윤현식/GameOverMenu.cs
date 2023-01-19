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
        GameOverMenuUI.SetActive(true); // GameOver �˾� â�� ȭ�鿡 ǥ�� ��Ű��
    }

    public void OnClick_Retry() // '�絵��' ��ư�� Ŭ���ϸ� ȣ�� �Ǿ��� �Լ�
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Stage1"); // SceneManager�� LoadScene �Լ��� ����Ͽ�! ���� �� 'GameScene'�� �ٽ� �ҷ������� ��Ų��.
                                             // ���� ���� �ٽ� �ҷ����� ������ ����� �ȴ�.
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
