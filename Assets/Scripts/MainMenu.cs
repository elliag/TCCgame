using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public SceneChanger stationInfo;   //accessing functions from SceneChanger script
    public Phone screen;
    static public int rand;
    static public bool startGame = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!startGame){
            setDestination();
            startGame = true;
        }


    }

    public void setDestination(){
        stationInfo.setStation(0);  //sets current station to mrs kipling station
        screen.setScreen("messageScreen");

        rand = (int)Mathf.Round(Random.Range(0.0f, 30.0f));
        Debug.Log(rand);
    }

    public int getDestination(){
        return rand;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
