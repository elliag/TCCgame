using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    //other scripts
    static public string direction;

    void Start(){

    }

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
    public void LoadEastPlatform(){
        setDirection("Eastbound");
        SceneManager.LoadScene(sceneName: "LineB_Platform");         //Load the Train Platform scene
    }
    public void LoadWestPlatform(){
        setDirection("Westbound");
        SceneManager.LoadScene(sceneName: "LineB_Platform");        //Load the Train Platform scene
    }
    public void LoadNorthPlatform(){
        setDirection("Northbound");
        SceneManager.LoadScene(sceneName: "LineB_Platform");        //Load the Train Platform scene
    }
    public void LoadSouthPlatform(){
        setDirection("Southbound");
        SceneManager.LoadScene(sceneName: "LineB_Platform");        //Load the Train Platform scene
    }
    public void LoadTrain(){
        setDirection(direction);
        //Load the Train scene
        SceneManager.LoadScene(sceneName: "LineB_Train");
    }

    public string getDirection(){
        return direction;
    }

    public void setDirection(string x){
        direction = x;
    }

}
