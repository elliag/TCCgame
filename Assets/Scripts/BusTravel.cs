using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusTravel : MonoBehaviour
{
    public SceneChanger stationInfo;

    public float timer;

    static public bool onBus;   //if the player is riding the bus
    static public int bus;  //1 = bus 1, 2 = bus 2

    public GameObject board;    //board bus button
    public GameObject exit;     //exit bus button

    public string[] temp = new string[30];  //for copying Line B stations array

    //First bus line on Line B
    static public string[] LineB_BusLine1 = new string[] {"Runnymead", "Vape", "Landsupe", "Cookswell", "Sherbert", "Batthirst", "Bossington", "Low Park", "Bufferin", "Bae", "Donedat West", "Donfalls", "Obamna", "Bester", "Rizzlington", "Elizabeth Park", "Fastle Crank", "Spagina", "Loosepine", "Regal Fork", "Floor-Olde", "Narrowview", "John", "Inmate", "Side Road", "St Peppa", "Brownleaf", "Peele", "Young Bill", "Mrs Kipling", "Crispie"};
        
    //Second bus line on Line B
    static public string[] LineB_BusLine2 = new string[] {"Inmate", "Spagina", "Fastle Crank", "Elizabeth Park", "Vape", "Mrs Kipling", "Peele", "Side Road", "Crispie", "Regal Fork", "Obamna", "Low Park", "Donedat West", "Runnymead", "Floor-Olde", "Cookswell", "Landsupe", "Narrowview", "John", "Bae", "Bester", "Batthirst", "Rizzlington", "Bossington", "Loosepine", "Young Bill", "Sherbert", "Brownleaf", "St Peppa", "Donfalls", "Bufferin"};
 

    // Start is called before the first frame update
    void Start()
    {
        timer = 6.0f;

        board.SetActive(false);
        exit.SetActive(false);

        //Copy Line B stations array
        for(int i = 0; i < LineB_BusLine1.Length; i++){
            temp [i] = stationInfo.getStation(i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; 

        //if on bus, start anim + timer
        if(onBus){
            if(timer < 0){
                exit.SetActive(true);
            }
        }
        else{
            if(timer < 3.0f){
                board.SetActive(true);
            }
        }
    }


    public string getStation_BusLine1(int x){
        return LineB_BusLine1[x];
    }

    public string getStation_BusLine2(int x){
        return LineB_BusLine2[x];
    }

    public void boardBus(){
        if(bus == 1){
            //set current station
            stationInfo.setStation(stationInfo.getStationIndex(LineB_BusLine1[stationInfo.getStationIndex()]));
            onBus = true;
        }
        else if (bus == 2){
            //set current station
            stationInfo.setStation(stationInfo.getStationIndex(LineB_BusLine2[stationInfo.getStationIndex()]));
            onBus = true;
        }
    }

    public void setBus(int x){
        bus = x;
    }

    public int getBus(){
        return bus;
    }

    public void exitBus(){
        onBus = false;
    }


}
