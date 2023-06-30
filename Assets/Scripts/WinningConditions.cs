using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningConditions : MonoBehaviour
{
    public MainMenu destination;
    public SceneChanger stationInfo;

    // Start is called before the first frame update
    void Start()
    {
        if(stationInfo.getStationIndex() == destination.getDestination()){
            Debug.Log("winner!");
        }
        else{
            Debug.Log("wrong station!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
