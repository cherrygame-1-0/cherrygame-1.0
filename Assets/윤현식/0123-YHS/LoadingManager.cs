using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManager : MonoBehaviour
{
    public Slider slider;
    public string SceneName;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadAsynSceneCoroutine());
    }
    IEnumerator LoadAsynSceneCoroutine()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);
        operation.allowSceneActivation = false;

        while(!operation.isDone)
        {
            time = +Time.time;
            slider.value = time / 3f;
            if(time>3)
            {
                operation.allowSceneActivation = true;
            }
            yield return null;
        }
    }

}
