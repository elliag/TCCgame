using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadMain(){
        //Load the Main Floor scene
        SceneManager.LoadScene(sceneName: "LineB_Main");
    }
    public void LoadTrainSelection(){
        //Load the Train Selection scene
        SceneManager.LoadScene(sceneName: "LineB_TrainSelection");
    }
    public void LoadBooth(){
        //Load the Operator Booth scene
        SceneManager.LoadScene(sceneName: "LineBBooth");
    }
    public void LoadPlatform(){
        //Load the Train Platform scene
        SceneManager.LoadScene(sceneName: "LineB_Platform");
    }
    public void LoadTrain(){
        //Load the Train scene
        SceneManager.LoadScene(sceneName: "LineB_Train");
    }

}
