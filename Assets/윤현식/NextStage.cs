using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public GameObject NextStageUI;

    public GameObject f_coin;
    public GameObject s_coin;
    public GameObject t_coin;

    public void Show()
    {
        NextStageUI.SetActive(true); // GameOver 팝업 창을 화면에 표시 시키고
        if (coindraw.coin >= 1)
        {
            f_coin.SetActive(true);
        }
        if(coindraw.coin>=2)
        {
            s_coin.SetActive(true);
        }    
        if(coindraw.coin>=3)
        {
            t_coin.SetActive(true);
        }
    }

    public void Goal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Stage2");
    }
}
