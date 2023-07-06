/*StationManager class updates the players current location while riding the train
Controls audio, animations, and player access while riding the train and waiting on the platform*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class StationManager : MonoBehaviour
{
    public float timer;    //time until train DEPARTS
    static public int station; //index of station in the stations array

    static public bool accessible; //if there is a train available OR if you have reached a station
    static public bool endOfTheLine; //if the current station is eastmost or westmost

    public bool onTrain;    //if the player is on the train
    public bool nextStationAnnouncement; //fixes a bug lol

    public GameObject allAboard;    //button to board train
    public GameObject exitTrain;    //button to exit train

    public TMP_Text timeText;

    public SceneChanger stationInfo;   //accessing functions from SceneChanger script to access the current station info
    public LineBPlatform platform;   //accessing functions from LineBPlatform script to play animations
    public Announcements announcements; // accessing functions from Announcements script to play audio clips


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

        //while the train is arriving text will display the countdown
        if (timer >= 16){
            timeText.text = Mathf.Abs((14 - Mathf.Round(timer))).ToString() + " seconds";
        }
        else{
            timeText.text = "arriving";
        }
        
        //checks if the player is at the end of the line
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

        //checks if the player is on the train or the platform
        switch (onTrain){
            case false:
            waitingForTrain();
            break;

            case true:
            ridingTrain();
            break;
        }

    }
        

    //controls audio clips, animations, and if the player can board the train
    public void waitingForTrain(){

        //train will arrive if the player is not at the end of the line and attempting to travel further
        if(!(stationInfo.getStationIndex() == 0 && String.Equals(stationInfo.getDirection(), "Westbound")) && !(stationInfo.getStationIndex() == 30 && String.Equals(stationInfo.getDirection(), "Eastbound"))){
            if (timer >= 21){
                platform.trainExit();   //train leaves anim
                accessible = false;
            }

            else if (timer <= 18 && timer >= 15){
                platform.trainEnter();  //train enters anim
            }

            //train arrives at the station and player can board
            else if (timer <= 15 && timer >= 8){
                platform.doorOpen();
                allAboard.SetActive(true);  // button to board train appears
                accessible = true;
            }

            else if(timer <= 7 && timer >= 6){
                announcements.doorsClosing();   //doors closing audio
            }

            //train leaves the station and player cannot board
            else if (accessible && timer <= 4){
                platform.doorClose();
                allAboard.SetActive(false);  // button to board train disappears
                accessible = false;
            }

            //process resets
            else if (!accessible && timer <= 0){
                resetTimer1();
            }
        }

    }


    //controls audio clips, animations, and if the player can exit the train
    public void ridingTrain(){

        if (timer >= 30){
            //train leave anim
            accessible = false;
            nextStationAnnouncement = true; //once the train leaves the station the announcement can play
        }

        else if(timer <= 30 && timer >= 29){
            if(nextStationAnnouncement){
                nextStation();  //next station announcement plays
            }

        }

        else if(timer <= 19 && timer >= 18){
            announcements.arrivalAnnouncement();    //while approaching the station the arrival announcement plays
        }

        //train stops at a station and player can deboard
        else if (timer <= 15 && timer >= 10){
            exitTrain.SetActive(true);  // button to exit train appears
            accessible = true;

            //if the current station is at the end of the line the audio will play
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

        //train continues moving and player cannot deboard
        else if (!endOfTheLine && !accessible && timer <= 0){
            exitTrain.SetActive(false);
            resetTimer2();
        }

    }

    //resets the timer for waiting on the platform
    public void resetTimer1(){
        timer = 25.0f;
    }

    //resets the timer for riding the train
    public void resetTimer2(){
        timer = 34.0f;
    }

    //controls the audio announcments for the next station and updates the current station info
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
        accessible = x;
    }




}
