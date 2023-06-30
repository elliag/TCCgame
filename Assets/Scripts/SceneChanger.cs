using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    static public string direction; //variable to hold the selected path of travel

    //array of every station on Line B
    static public string[] LineB_Stations = new string[] {"Mrs Kipling", "Rizzlington", "Regal Fork", "Young Bill", "John", "Runnymead", "Low Park", "Peele", "Donedat West", "Landsupe", "Bufferin", "Bossington", "Crispie", "Batthirst", "Spagina", "St Peppa", "Bae", "Floor-Olde", "Sherbert", "Fastle Crank", "Narrowview", "Bester", "Vape", "Donfalls", "Brownleaf", "Cookswell", "Loosepine", "Side Road", "Elizabeth Park", "Inmate", "Obamna"};
 
    static public string currentStation;
    static public int stationIndex;


    public void LoadMain_LineB(){
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
        SceneManager.LoadScene(sceneName: "LineB_Train");           //Load Train scene
    }
    public void LoadTerminal(){             
        SceneManager.LoadScene(sceneName: "LineB_BusTerminal");           //Load bus terminal scene
    }

    public void exitTrain(){
        switch(direction)
        {
            case "Westbound":
            LoadWestPlatform();
            break;

            case "Eastbound":
            LoadEastPlatform();
            break;

            case "NorthBound":
            LoadNorthPlatform();
            break;

            case "Southbound":
            LoadSouthPlatform();
            break;
        }
    }

    public string getDirection(){
        return direction;
    }

    public void setDirection(string x){
        direction = x;
    }

    public string getStation(){
        return currentStation;
    }

    public string getStation(int x){
        return LineB_Stations[x];
    }

    public void setStation(int x){
        currentStation = LineB_Stations[x];
    }

    public int getStationIndex(){
        stationIndex = System.Array.IndexOf (LineB_Stations, currentStation);
        return stationIndex;
    }

    public string[] getLineB(){
        string[] stationsCopy = new string[30];

        for(int x = 0; x < LineB_Stations.Length; x++){
            stationsCopy[x] = LineB_Stations[x];
        }
        
        return stationsCopy;
    }

}
