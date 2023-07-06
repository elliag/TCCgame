//LineBTrainSelect Class controls which directions the player can choose to travel based on their current station
//Players cannot go westbound on the westmost station or eastbound on the eastmost station

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBTrainSelect : MonoBehaviour
{
    public SceneChanger stationInfo;   //accessing functions from SceneChanger script to access the current station

    public GameObject eastbound;    //to eastbound button
    public GameObject westbound;    //to westbound button

    public GameObject eastboundIcon;    //to eastbound icon
    public GameObject westboundIcon;    //to westbound icon

    public GameObject map;    //map canvas

    // Start is called before the first frame update
    void Start()
    {
        map.SetActive(false);

        switch(stationInfo.getStation()){   // determines which directions player can access based on their current station
            case "Mrs Kipling":
            westbound.SetActive(false);
            westboundIcon.SetActive(false);
            eastbound.SetActive(true);
            eastboundIcon.SetActive(true);
            break;

            case "Obamna":
            westbound.SetActive(true);
            westboundIcon.SetActive(true);
            eastbound.SetActive(false);
            eastboundIcon.SetActive(false);
            break;

            default:
                westbound.SetActive(true);
                westboundIcon.SetActive(true);
                eastbound.SetActive(true);
                eastboundIcon.SetActive(true);
            break;
        }
        
    }
}
