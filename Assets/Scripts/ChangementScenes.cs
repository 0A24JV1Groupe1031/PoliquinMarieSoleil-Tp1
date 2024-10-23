using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangementScenes : MonoBehaviour
{
    public void ChangerSceneUn(){
        SceneManager.LoadScene(1);
        
    }
    public void ChangerSceneDeux(){
        SceneManager.LoadScene(2);
        
    }
    public void ChangerSceneTrois(){
        SceneManager.LoadScene(3);
        
    }
}
