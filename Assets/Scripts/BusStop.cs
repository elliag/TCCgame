using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;


public class BusStop : MonoBehaviour
{
    public SceneChanger stationInfo;
    public BusTravel busLine;

    public TMP_Text destination;
    public TMP_Text number;

    // Start is called before the first frame update
    void Start()
    {
        switch(busLine.getBus()){
            case 1:
            destination.text = busLine.getStation_BusLine1(stationInfo.getStationIndex());
            number.text = "1";
            break;

            case 2:
            destination.text = busLine.getStation_BusLine2(stationInfo.getStationIndex());
            number.text = "2";
            break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
