using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


using TMPro;
using System;
public class StationManager : MonoBehaviour
{
    public float timer;    //time until train DEPARTS
    public bool arriving;   //time until train ARRIVES

    public bool trainAvailable; //if there is a train at the station

    public bool onTrain;    //if the player is on the train

    public string[] LineB_Stations;

    public GameObject allAboard;    //button to board train

    public TMP_Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        timer = 16.0f;
        trainAvailable = false;
        onTrain = false;
        allAboard.SetActive(false);
        arriving = true;

        //stations on Line B
        LineB_Stations = new string[] {"Mrs Kipling", "Rizzlington", "Young Bill", "John", "Runnymead", "Low Park", "Peele", "Donedat West", "Lansupe", "Bufferin", "Bossington", "Crispie", "Batthirst", "Spagina", "St Peppa", "Bae", "Floor-Olde", "Sherbert", "Fastle Crank", "Narrowview", "Bester", "Vape", "Donfalls", "Brownleaf", "Cookswell", "Loosepine", "Side Road", "Elizabeth Park", "Inmate", "Obamna"};

        //waitingForTrain();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;      // counts down until the train arrives
        timeText.text = timer.ToString();

        if (timer <= 8){
            //trainAvailable = true;      // train is at the station
            allAboard.SetActive(true);  // button to board train appears
            arriving = false;
        }
            if (!arriving && timer <= 0){
                trainAvailable = false;      // train is not at the station
                allAboard.SetActive(false);  // button to board train disappears
                arriving = true;
                resetTimer();
            }
            
    }

    public void resetTimer(){
        timer = 16.0f;
    }

    public void boardTrain(){
        onTrain = true;
    }


}
