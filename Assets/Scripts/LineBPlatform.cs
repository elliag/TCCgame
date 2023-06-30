using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;


public class LineBPlatform : MonoBehaviour
{
    public Animator anim;

    public GameObject train;

    public TMP_Text direction_text;
    public TMP_Text pathOfTravel_text;

    public TMP_Text station_text;

    public SceneChanger platformInfo;   //accessing functions from SceneChanger script
    public StationManager trainStatus;   //accessing functions from StationManager script

    public string test;


    // Start is called before the first frame update
    void Start()
    {
        
        trainStatus.onboardTrain(false);

        direction_text.text = platformInfo.getDirection();
        
        if(String.Equals(platformInfo.getDirection(), "Westbound")){
            pathOfTravel_text.text = "To Mrs Kipling";
        }
        else if(String.Equals(platformInfo.getDirection(), "Eastbound")){
            pathOfTravel_text.text = "To Obamna";
        }
        
        station_text.text = platformInfo.getStation();

    }

    public void trainEnter(){
        anim.Play("Train_Enter");
    }

    public void trainExit(){
        anim.Play("Train_Exit");
    }

    public void doorOpen(){
        anim.Play("DoorOpen");
    }

    public void doorClose(){
        anim.Play("DoorClose");
    }

    // Update is called once per frame
    void Update()
    {

       
    }

}
