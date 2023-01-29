using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BtnType : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public BTNType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup stageGroup;
    public CanvasGroup optionGroup;
    public CanvasGroup storeGroup; // ���� 
    GameObject cherry;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
        cherry = GameObject.Find("chery");
        //cherry.SetActive(true);


    }
    bool isSound;
    public void OnBtnClick()
    {
        switch(currentType)
        {
            case BTNType.Play:
                //SceneManager.LoadScene("LoadingManager"); �� �ȵ� ����
                Debug.Log("���ӽ���");
                break;
            case BTNType.Stage:
                Debug.Log("�������� ����");
                //print("�����ν� " + GameObject.Find("datadase").GetComponent<database>().nowPlayer.level);
                CanvasGroupOn(stageGroup);
                CanvasGroupOff(optionGroup);
                CanvasGroupOff(mainGroup);
                CanvasGroupOff(storeGroup);
                cherry.SetActive(false);
                break;
            case BTNType.Option:
                CanvasGroupOn(optionGroup);
                CanvasGroupOff(mainGroup);
                CanvasGroupOff(stageGroup);
                CanvasGroupOff(storeGroup);
                cherry.SetActive(false);
                break;
            case BTNType.Store:
                CanvasGroupOn(storeGroup);
                CanvasGroupOff(mainGroup);
                CanvasGroupOff(stageGroup);
                CanvasGroupOff(optionGroup);
                cherry.SetActive(false);
                break;
            case BTNType.Sound:
                if(isSound)
                {
                    Debug.Log("���� ����");
                }
                else
                {
                    Debug.Log("���� �ѱ�");     
                }
                isSound = !isSound;
                break;
            case BTNType.Back:
                cherry.SetActive(true);
                print("��");
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(optionGroup);
                CanvasGroupOff(stageGroup);
                CanvasGroupOff(storeGroup);
                //cherry.SetActive(true);
                break;
            case BTNType.Quit:
                Application.Quit();
                Debug.Log("�� ����");
                break;
        }
    }

    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.2f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
