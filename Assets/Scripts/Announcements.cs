using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Announcements : MonoBehaviour
{
    public SceneChanger stationInfo;   //accessing functions from SceneChanger script

    static AudioSource audioData;
    public AudioClip[] stations = new AudioClip[34];


    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LastStopAnnouncement(){
        audioData.PlayOneShot(stations[31]);
    }

    public void arrivalAnnouncement(){
        audioData.PlayOneShot(stations[32]);
    }

    public void doorsClosing(){
        audioData.PlayOneShot(stations[33]);
    }

    public void trainAnnouncments(){

        switch(stationInfo.getStation()){
            case "Mrs Kipling":
            audioData.PlayOneShot(stations[0]);
            break;

            case "Rizzlington":
            audioData.PlayOneShot(stations[1]);
            break;

            case "Regal Fork":
            audioData.PlayOneShot(stations[2]);
            break;

            case "Young Bill":
            audioData.PlayOneShot(stations[3]);
            break;

            case "John":
            audioData.PlayOneShot(stations[4]);
            break;

            case "Runnymead":
            audioData.PlayOneShot(stations[5]);
            break;

            case "Low Park":
            audioData.PlayOneShot(stations[6]);
            break;

            case "Peele":
            audioData.PlayOneShot(stations[7]);
            break;

            case "Donedat West":
            audioData.PlayOneShot(stations[8]);
            break;

            case "Landsupe":
            audioData.PlayOneShot(stations[9]);
            break;

            case "Bufferin":
            audioData.PlayOneShot(stations[10]);
            break;

            case "Bossington":
            audioData.PlayOneShot(stations[11]);
            break;

            case "Crispie":
            audioData.PlayOneShot(stations[12]);
            break;

            case "Batthirts":
            audioData.PlayOneShot(stations[13]);
            break;

            case "Spagina":
            audioData.PlayOneShot(stations[14]);
            break;

            case "St Peppa":
            audioData.PlayOneShot(stations[15]);
            break;

            case "Bae":
            audioData.PlayOneShot(stations[16]);
            break;

            case "Floor-Olde":
            audioData.PlayOneShot(stations[17]);
            break;

            case "Sherbert":
            audioData.PlayOneShot(stations[18]);
            break;

            case "Fastle Crank":
            audioData.PlayOneShot(stations[19]);
            break;

            case "Narrowview":
            audioData.PlayOneShot(stations[20]);
            break;

            case "Bester":
            audioData.PlayOneShot(stations[21]);
            break;

            case "Vape":
            audioData.PlayOneShot(stations[22]);
            break;

            case "Donfalls":
            audioData.PlayOneShot(stations[23]);
            break;

            case "Brownleaf":
            audioData.PlayOneShot(stations[24]);
            break;

            case "Cookswell":
            audioData.PlayOneShot(stations[25]);
            break;

            case "Loosepine":
            audioData.PlayOneShot(stations[26]);
            break;

            case "Side Road":
            audioData.PlayOneShot(stations[27]);
            break;

            case "Elizabeth Park":
            audioData.PlayOneShot(stations[28]);
            break;

            case "Inmate":
            audioData.PlayOneShot(stations[29]);
            break;

            case "Obamna":
            audioData.PlayOneShot(stations[30]);
            break;
        }
    }
}
