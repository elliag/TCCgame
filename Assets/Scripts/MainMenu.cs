//MainMenu Class generates a destination for the player and opens the phone messaging app for the player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public SceneChanger stationInfo;   // accessing functions from SceneChanger script
    public Phone screen;    // phone canvas
    static public int rand;
    static public bool startGame = false;   //bool to stop the script from regenerating a new destination

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
        screen.setScreen("messageScreen");  //messaging app will appear when the player enters the game

        rand = (int)Mathf.Round(Random.Range(0.0f, 30.0f)); // generates a random int to select a destination station within the stations array
    }

    public int getDestination(){
        return rand;
    }

}
