using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;


public class Phone : MonoBehaviour{

    public SceneChanger stationInfo;
    public MainMenu destination;
    
    public GameObject buttons;    
    public GameObject phoneDisplay;    

    public TMP_Text timeDisplay;
    DateTime time;

    public TMP_Text song;
    public TMP_Text station;

     public int currentSong;
    static public string currentScreen;

    public GameObject home;
    public GameObject music;
    public GameObject notes;
    public GameObject message;

    public GameObject psych;
    public GameObject hello;
    public GameObject funk;

    public GameObject pauseButton;
    public GameObject pauseIcon;
    public GameObject playButton;




    // Start is called before the first frame update
    void Start()
    {
        playButton.SetActive(false);
        station.text = stationInfo.getStation(destination.getDestination());
    }

    // Update is called once per frame
    void Update()
    {

        time = DateTime.Now;
        if (time.Hour < 12){ 
            timeDisplay.text = padding(time.Hour) + ":" + padding(time.Minute) + " AM";
        }
        else{
            timeDisplay.text = padding(time.Hour) + ":" + padding(time.Minute) + " PM";
        }
        
        switch(currentScreen){
            case "homeScreen":
            home.SetActive(true);
            music.SetActive(false);
            notes.SetActive(false);
            message.SetActive(false);
            break;

            case "musicScreen":
            home.SetActive(false);
            music.SetActive(true);
            notes.SetActive(false);
            message.SetActive(false);
            musicScreen();
            break;

            case "notesScreen":
            home.SetActive(false);
            music.SetActive(false);
            notes.SetActive(true);
            message.SetActive(false);
            notesScreen();
            break;

            case "messageScreen":
            home.SetActive(false);
            music.SetActive(false);
            notes.SetActive(false);
            message.SetActive(true);
            break;

            case "off":
            home.SetActive(false);
            music.SetActive(false);
            notes.SetActive(false);
            message.SetActive(false);
            break;

        }
    }

    public string padding (int n){
        return n.ToString().PadLeft(2, '0');
    }


    public void musicScreen(){
        switch(currentSong){
            case 0:
            song.text = "Psychedeli...";
            psych.SetActive(true);
            hello.SetActive(false);
            funk.SetActive(false);
            break;

            case 1:
            song.text = "Say Hello";
            psych.SetActive(false);
            hello.SetActive(true);
            funk.SetActive(false);
            break;

            case 2:
            song.text = "funk so wh...";
            psych.SetActive(false);
            hello.SetActive(false);
            funk.SetActive(true);
            break;
        }
    }

    public void pause(){
        pauseButton.SetActive(false);
        pauseIcon.SetActive(false);
        playButton.SetActive(true);
    }

    public void play(){
        pauseButton.SetActive(true);
        pauseIcon.SetActive(true);
        playButton.SetActive(false);
    }



    public void notesScreen(){

    }


    public void setScreen(string x){
        currentScreen = x;
    }

    
    public void setSong(int x){
        currentSong = x;
    }

    public int getSong(){
        return currentSong;
    }

    public void openPhone(){
        buttons.SetActive(false);
        phoneDisplay.SetActive(true);
        setScreen("homeScreen");
    }

    
    public void closePhone(){
        setScreen("off");
        buttons.SetActive(true);
        phoneDisplay.SetActive(false);
    }
    
}
