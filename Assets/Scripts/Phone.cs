//Phone class controls the diplay of phone screens 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;


public class Phone : MonoBehaviour{

    public SceneChanger stationInfo;    //accessing functions from SceneChanger script to convert destination to text format
    public MainMenu destination;    //accessing functions from MainMenu to check the destination

    public GameObject buttons;  //UI buttons in the background
    public GameObject phoneDisplay; //phone canvas   

    //time display on home screen
    public TMP_Text timeDisplay;
    DateTime time;

    public TMP_Text song;   //text to display the current song on music app
    public TMP_Text station;    //text to display the destination on messaging app

    public int currentSong;
    static public string currentScreen;

    //canvases for the different app screens
    public GameObject home;
    public GameObject music;
    public GameObject notes;
    public GameObject message;

    //album cover icons for songs on music app
    public GameObject psych;
    public GameObject hello;
    public GameObject funk;

    //UI icons for music app
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

    //displays the current time
        time = DateTime.Now;
        if (time.Hour < 12){ 
            timeDisplay.text = padding(time.Hour) + ":" + padding(time.Minute) + " AM";
        }
        else{
            timeDisplay.text = padding(time.Hour) + ":" + padding(time.Minute) + " PM";
        }
        
    //controls which app screen is displayed on the phone
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

//adds a 0 when necessary to the time 
    public string padding (int n){
        return n.ToString().PadLeft(2, '0');
    }


    //displays the current song on the music app
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

    //displays correct UI icons when music is paused
    public void pause(){
        pauseButton.SetActive(false);
        pauseIcon.SetActive(false);
        playButton.SetActive(true);
    }

    //displays correct UI icons when music is played
    public void play(){
        pauseButton.SetActive(true);
        pauseIcon.SetActive(true);
        playButton.SetActive(false);
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
