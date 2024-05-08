using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MapsMenu : MonoBehaviour
{
    public void BackToMenu(){
        SceneManager.LoadSceneAsync(0);
    }

        public void Level_1(){
        SceneManager.LoadSceneAsync(2);
    }

    
        public void Level_2(){
        SceneManager.LoadSceneAsync(3);
    }
    
        public void Level_3(){
        SceneManager.LoadSceneAsync(4);
    }
}
