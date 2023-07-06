using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusTravel : MonoBehaviour
{
    public SceneChanger stationInfo;

    public bool onBus;

    public string[] temp = new string[30];  //for copying Line B stations array

    //First bus line on Line B
    static public string[] LineB_BusLine1 = new string[] {"Runnymead", "Vape", "Landsupe", "Cookswell", "Sherbert", "Batthirst", "Bossington", "Low Park", "Bufferin", "Bae", "Donedat West", "Donfalls", "Obamna", "Bester", "Rizzlington", "Elizabeth Park", "Fastle Crank", "Spagina", "Loosepine", "Regal Fork", "Floor-Olde", "Narrowview", "John", "Inmate", "Side Road", "St Peppa", "Brownleaf", "Peele", "Young Bill", "Mrs Kipling", "Crispie"};
        
    //Second bus line on Line B
    static public string[] LineB_BusLine2 = new string[] {"Loosepine", "Elizabeth Park", "Bae", "Batthirst", "St Peppa", "Inmate", "John", "Sherbert", "Bester", "Bossington", "Fastle Crank", "Vape", "Floor-Olde", "Donfalls", "Narrowview", "Donedat West", "Obamna", "Crispie", "Young Bill", "Side Road", "Peele", "Spagina", "Landsupe", "Low Park", "Mrs Kipling", "Rizzlington", "Bufferin", "Runnymead", "Brownleaf", "Cookswell", "Regal Fork"};
 

    // Start is called before the first frame update
    void Start()
    {

        //Copy Line B stations array
        for(int i = 0; i < LineB_BusLine1.Length; i++){
            temp [i] = stationInfo.getStation(i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //if on bus, start anim + timer
        if(onBus){

        }
    }



    public string getStation_BusLine1(int x){
        return LineB_BusLine1[x];
    }

    public string getStation_BusLine2(int x){
        return LineB_BusLine2[x];
    }

    public void boardBus(int x){
        if(x == 1){
            //set current station
            stationInfo.setStation(stationInfo.getStationIndex(LineB_BusLine1[stationInfo.getStationIndex()]));
            onBus = true;
        }
        else {
            //set current station
            stationInfo.setStation(stationInfo.getStationIndex(LineB_BusLine2[stationInfo.getStationIndex()]));
            onBus = true;
        }
    }

    public void exitBus(){
        onBus = false;
        stationInfo.LoadTerminal();     //load bus terminal scene
    }


}
