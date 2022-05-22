using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    [SerializeField] string next;
    public void gotoScene()
    {
        SceneManager.LoadScene(next);
    }
    public void quit()
    {
        Application.Quit();
    }
}
