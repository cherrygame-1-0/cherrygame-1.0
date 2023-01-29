using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_TO_Menu : MonoBehaviour
{
    public void OnClick_Move()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
