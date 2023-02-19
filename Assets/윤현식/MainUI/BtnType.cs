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
    public CanvasGroup _1Theme;
    public CanvasGroup _2Theme;
    public CanvasGroup _3Theme;
    public CanvasGroup _4Theme;
    public CanvasGroup _5Theme;
    public CanvasGroup _6Theme;
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
                
                //GameObject.Find("datadase").GetComponent<database>().Loadcall();
                print("�����ν� " + GameObject.Find("datadase").GetComponent<database>().nowPlayer.level);
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
            case BTNType.Theme1:
                CanvasGroupOn(_1Theme);
                CanvasGroupOff(stageGroup);
                Debug.Log("1�׸� ���õ�");
                break;
            case BTNType.Theme2:
                CanvasGroupOn(_2Theme);
                CanvasGroupOff(stageGroup);
                Debug.Log("2�׸� ���õ�");
                break;
            case BTNType.Theme3:
                CanvasGroupOn(_3Theme);
                CanvasGroupOff(stageGroup);
                Debug.Log("3�׸� ���õ�");
                break;
            case BTNType.Theme4:
                CanvasGroupOn(_4Theme);
                CanvasGroupOff(stageGroup);
                Debug.Log("4�׸� ���õ�");
                break;
            case BTNType.Theme5:
                CanvasGroupOn(_5Theme);
                CanvasGroupOff(stageGroup);
                Debug.Log("5�׸� ���õ�");
                break;
            case BTNType.Theme6:
                CanvasGroupOn(_6Theme);
                CanvasGroupOff(stageGroup);
                Debug.Log("6�׸� ���õ�");
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
