using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SelectLevel(){
        SceneManager.LoadSceneAsync(1);
    }

    public void quit()
    {
        Application.Quit();
    }
}
