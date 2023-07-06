//PhoneMusic class controls the audio played from the music app on the phone, and the display of the current song

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PhoneMusic : MonoBehaviour{

    static AudioSource phoneMusic;
    public AudioClip[] songs = new AudioClip[3];    // holds songs to play

    public Phone music; //accessing functions from Phone script to control the display

    // Start is called before the first frame update
    void Start()
    {
        phoneMusic = GetComponent<AudioSource>();
        music.closePhone();
    }

    public void psychedelicacy(){   //play psychedelicacy
        music.setSong(0);
        phoneMusic.PlayOneShot(songs[0]);
    }

    public void sayHello(){ //play say hello
        music.setSong(1);
        phoneMusic.PlayOneShot(songs[1]);
    }

    public void funkSoWhat(){   //play funk so what
        music.setSong(2);
        phoneMusic.PlayOneShot(songs[2]);
    }

    //when the next icon is clicked the next song will play
    public void next(){
        if (music.getSong() == 2){
            phoneMusic.Stop();
            music.setSong(0);
            phoneMusic.PlayOneShot(songs[0]);
        }
        else{
            phoneMusic.Stop();
            phoneMusic.PlayOneShot(songs[music.getSong() + 1]);
            music.setSong(music.getSong()+1);

        }
    } 

    //when the back icon is clicked the previous song will play
    public void back(){
        if (music.getSong() == 0){
            phoneMusic.Stop();
            music.setSong(2);
            phoneMusic.PlayOneShot(songs[2]);
        }
        else{
            phoneMusic.Stop();
            phoneMusic.PlayOneShot(songs[music.getSong() - 1]);
            music.setSong(music.getSong()-1);
        }
    }

}

