//Updates the display of what buses are available at the bus terminal based on your current TCC station

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class LineBBusTerminal : MonoBehaviour
{
    public SceneChanger stationInfo;
    public BusTravel busLine;

    public TMP_Text bus1_text;
    public TMP_Text bus2_text;

    public int whichBus;

    // Start is called before the first frame update
    void Start()
    {
        whichBus = 0;   //1 = bus 1, 2 = bus 2

        bus1_text.text = busLine.getStation_BusLine1(stationInfo.getStationIndex());
        bus2_text.text = busLine.getStation_BusLine2(stationInfo.getStationIndex());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //can delete this
    public void busDisplay(int x){
        bus1_text.text = busLine.getStation_BusLine1(x);
        bus2_text.text = busLine.getStation_BusLine2(x);
    }


}
