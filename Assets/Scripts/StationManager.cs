using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class StationManager : MonoBehaviour
{
    public float timer;    //time until train DEPARTS

    static public bool accessible; //if there is a train available OR if you have reached a station
    static public bool endOfTheLine; //if there is a train available OR if you have reached a station

    public bool onTrain;    //if the player is on the train
    public bool nextStationAnnouncement; //fixes a bug lol

    public GameObject allAboard;    //button to board train
    public GameObject exitTrain;    //button to exit train

    public TMP_Text timeText;

    public SceneChanger stationInfo;   //accessing functions from SceneChanger script
    public LineBPlatform platform;   //accessing functions from LineBPlatform script
    public Announcements announcements;
    static public int station; //index of station in the stations array

    // Start is called before the first frame update
    void Start()
    {
        timer = 25.0f;
        allAboard.SetActive(false);
        exitTrain.SetActive(false);

        station = stationInfo.getStationIndex();
        nextStationAnnouncement = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;      // counts down until the train arrives
        if (timer >= 16){
            timeText.text = Mathf.Abs((14 - Mathf.Round(timer))).ToString() + " seconds";
        }
        else{
            timeText.text = "arriving";
        }
        
        switch (stationInfo.getStation()){
            case "Mrs Kipling":
                endOfTheLine = true;
            break;
            case "Obamna":
                endOfTheLine = true;
            break;
            default:
                endOfTheLine = false;
            break;
        }

        switch (onTrain){
            case false:
            waitingForTrain();
            break;

            case true:
            ridingTrain();
            break;
        }

    }
        


    public void waitingForTrain(){

        if (timer >= 21){
            //train leaves anim
            platform.trainExit();
            accessible = false;
        }
        else if (timer <= 18 && timer >= 15){
            platform.trainEnter();
        }

        //after 14 seconds, train arrives at the station and player can board
        else if (timer <= 15 && timer >= 8){
            allAboard.SetActive(true);  // button to board train appears
            accessible = true;
        }

        else if(timer <= 7 && timer >= 6){
            announcements.doorsClosing();
        }
        //after 24 seconds, train leaves the station and player cannot board
        else if (accessible && timer <= 4){
            allAboard.SetActive(false);  // button to board train disappears
            accessible = false;
        }
        else if (!accessible && timer <= 0){
            resetTimer1();
        }

    }

    public void ridingTrain(){

        if (timer >= 30){
            //train leave anim
            accessible = false;
            nextStationAnnouncement = true;
        }

        else if(timer <= 30 && timer >= 29){
            if(nextStationAnnouncement){
                nextStation();
            }

        }

        else if(timer <= 19 && timer >= 18){
            announcements.arrivalAnnouncement();
        }

        //After 12 seconds, train stops at a station and player can deboard
        else if (timer <= 15 && timer >= 10){
            exitTrain.SetActive(true);  // button to exit train appears
            accessible = true;

            if(endOfTheLine){
                timeText.text = "Last Station";
                announcements.LastStopAnnouncement();
            }
        }

        else if(timer <= 9 && timer >= 8){
            announcements.doorsClosing();
        }

        else if(timer <= 3 && timer >= 0){
            accessible = false;
            //door close anim
        }

        //after 16 seconds, train continues moving and player cannot deboard
        else if (!endOfTheLine && !accessible && timer <= 0){
            exitTrain.SetActive(false);
            //nextStation();
            resetTimer2();
        }

    }

    public void resetTimer1(){
        timer = 25.0f;
    }
    public void resetTimer2(){
        timer = 34.0f;
    }

    public void nextStation(){
        switch(stationInfo.getDirection()){
            case "Westbound":
            station -= 1;
            stationInfo.setStation(station);
            break;

            case "Eastbound":
            station += 1;
            stationInfo.setStation(station);
            break;
        }

        stationInfo.setStation(station);
        announcements.stationAnnouncments();
        nextStationAnnouncement = false;
    }

    public void onboardTrain(bool x){
        onTrain = x;
    }

    public bool getAccessible(){
        return accessible;  //returns if the player can board/deboard train
    }

    public void setAccessible(bool x){
        accessible = x;  //returns if the player can board/deboard train
    }




}
