using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBTrainSelect : MonoBehaviour
{
    public SceneChanger stationInfo;   //accessing functions from SceneChanger script

    public GameObject eastbound;    //to eastbound button
    public GameObject westbound;    //to westbound button

    public GameObject eastboundIcon;    //to eastbound button
    public GameObject westboundIcon;    //to westbound button

    public GameObject map;    //map canvas

    // Start is called before the first frame update
    void Start()
    {
        map.SetActive(false);

        switch(stationInfo.getStation()){
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
