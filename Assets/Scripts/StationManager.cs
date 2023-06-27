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

    public GameObject allAboard;    //button to board train
    public GameObject exitTrain;    //button to exit train

    public TMP_Text timeText;

    public SceneChanger stationInfo;   //accessing functions from SceneChanger script
    public Announcements announcements;
    static public int station; //index of station in the stations array

    // Start is called before the first frame update
    void Start()
    {
        timer = 16.0f;
        allAboard.SetActive(false);
        exitTrain.SetActive(false);

        station = stationInfo.getStationIndex();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;      // counts down until the train arrives
        timeText.text = timer.ToString();
        
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

        //after 8 seconds, train arrives at the station and player can board
        if (timer <= 8){
            allAboard.SetActive(true);  // button to board train appears
            accessible = true;
        }

        if(timer <= 4 && timer >= 1){
            announcements.doorsClosing();
        }
        //after 16 seconds, train leaves the station and player cannot board
        if (accessible && timer <= 0){
            allAboard.SetActive(false);  // button to board train disappears
            accessible = false;
            resetTimer();
        }

    }

    public void ridingTrain(){

        if(timer <= 10 && timer >= 8){
            announcements.arrivalAnnouncement();
        }

        //After 8 seconds, train stops at a station and player can deboard
        if (timer <= 8){
            exitTrain.SetActive(true);  // button to exit train appears
            accessible = true;

            if(endOfTheLine){
                timeText.text = "Last Station";
                announcements.LastStopAnnouncement();
            }
        }

        if(timer <= 2 && timer >= 0){
            announcements.doorsClosing();
        }

        //after 16 seconds, train continues moving and player cannot deboard
        if (!endOfTheLine && accessible && timer <= 0){
            exitTrain.SetActive(false);
            accessible = false;
            nextStation();
            resetTimer();
        }

    }

    public void resetTimer(){
        timer = 16.0f;
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
        announcements.trainAnnouncments();
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
