using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBTrainSelect : MonoBehaviour
{
    public SceneChanger stationInfo;   //accessing functions from SceneChanger script

    public GameObject eastbound;    //to eastbound button
    public GameObject westbound;    //to westbound button

    // Start is called before the first frame update
    void Start()
    {


        switch(stationInfo.getStation()){
            case "Mrs Kipling":
            westbound.SetActive(false);
            eastbound.SetActive(true);
            break;

            case "Obamna":
            westbound.SetActive(true);
            eastbound.SetActive(false);
            break;

            default:
                westbound.SetActive(true);
                eastbound.SetActive(true);
            break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
