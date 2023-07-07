/*SceneChanger class controls the loading of the different scenes, and holds the information on the current station,
path of travel, and stations on the Lines */

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
    static public int stationIndex; //holds the index of the current station


    //Loads the Main Floor scene
    public void LoadMain_LineB(){
        SceneManager.LoadScene(sceneName: "LineB_Main");
    }

    //Loads the Train Selection Scene
    public void LoadTrainSelection(){
        SceneManager.LoadScene(sceneName: "LineB_TrainSelection");
    }

    //Loads the Operator booth scene
    public void LoadBooth(){
        SceneManager.LoadScene(sceneName: "LineBBooth");
    }

    //Load the Platform scene and sets the direction to eastbound
    public void LoadEastPlatform(){
        setDirection("Eastbound");
        SceneManager.LoadScene(sceneName: "LineB_Platform");
    }

    //Load the Platform scene and sets the direction to westbound
    public void LoadWestPlatform(){
        setDirection("Westbound");
        SceneManager.LoadScene(sceneName: "LineB_Platform");
    }

    //Load the Platform scene and sets the direction to northbound
    public void LoadNorthPlatform(){
        setDirection("Northbound");
        SceneManager.LoadScene(sceneName: "LineB_Platform");
    }

    //Load the Platform scene and sets the direction to southbound
    public void LoadSouthPlatform(){
        setDirection("Southbound");
        SceneManager.LoadScene(sceneName: "LineB_Platform");
    }

    //Loads the Train scene
    public void LoadTrain(){
        setDirection(direction);
        SceneManager.LoadScene(sceneName: "LineB_Train");
    }

    //Loads the bus terminal scene
    public void LoadTerminal(){             
        SceneManager.LoadScene(sceneName: "LineB_BusTerminal");
    }

    //Loads the bus stop scene
    public void LoadBusStop(){             
        SceneManager.LoadScene(sceneName: "BusStop");
    }

    //Loads the bus scene
    public void LoadBus(){             
        SceneManager.LoadScene(sceneName: "Bus");
    }

    //Loads the correct train platform when exiting the train
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

    //returns the current station in string format
    public string getStation(){
        return currentStation;
    }

    //returns the station by converting the index to string format
    public string getStation(int x){
        return LineB_Stations[x];
    }

    //sets the station using a station index
    public void setStation(int x){
        currentStation = LineB_Stations[x];
    }

    //returns the current station's index
    public int getStationIndex(){
        stationIndex = System.Array.IndexOf (LineB_Stations, currentStation);
        return stationIndex;
    }

    //returns a station's index
    public int getStationIndex(string name){
        int temp = System.Array.IndexOf (LineB_Stations, name);
        return temp;
    }

    //copies the array of LineB stations
    public string[] getLineB(){
        string[] stationsCopy = new string[30];

        for(int x = 0; x < LineB_Stations.Length; x++){
            stationsCopy[x] = LineB_Stations[x];
        }
        
        return stationsCopy;
    }

}
