using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public SceneChanger stationInfo;   //accessing functions from SceneChanger script

    // Start is called before the first frame update
    void Start()
    {
        stationInfo.setStation(0);  //sets current station to mrs kipling station
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
