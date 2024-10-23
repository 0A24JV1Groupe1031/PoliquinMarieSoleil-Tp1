using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangementScenes : MonoBehaviour
{
    public void ChangerSceneUn(){
        SceneManager.LoadScene("ChambreMaison2");
        
    }
    public void ChangerSceneDeux(){
        SceneManager.LoadScene("SalonMaison2");
        
    }
    public void ChangerSceneTrois(){
        SceneManager.LoadScene("SalleDeBainMaison2");
        
    }
}
