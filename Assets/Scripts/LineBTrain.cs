// LineBTrain Class 'resets' the train scene to its natural state and controls text display and animations that occur on the train

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class LineBTrain : MonoBehaviour
{
    public Animator anim;

    public TMP_Text status;    //current station

    public SceneChanger stationInfo;   //accessing functions from SceneChanger script to check current station
    public StationManager trainStatus;   //accessing functions from StationManager script to update current station text

    public GameObject map;    //map canvas

    // Start is called before the first frame update
    void Start()
    {
        trainStatus.setAccessible(false);
        trainStatus.onboardTrain(true);
        //trainStatus.nextStation();

        map.SetActive(false);

        trainStatus.resetTimer2();
    }

    // Update is called once per frame
    void Update()
    {
        switch(trainStatus.getAccessible()){
            //if train is at the station
            case true:
            status.text = "Now arriving at " + stationInfo.getStation();
            break;

            //if train is moving
            case false:
            status.text = "Next station is " + stationInfo.getStation();
            break;
        }

    }

    public void doorOpen(){
        anim.Play("DoorOpenInside");
    }

    public void doorClose(){
        anim.Play("DoorCloseInside");
    }


}
