using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PhoneMusic : MonoBehaviour{

    static AudioSource phoneMusic;
    public AudioClip[] songs = new AudioClip[3];

    public Phone music;

    // Start is called before the first frame update
    void Start()
    {
        phoneMusic = GetComponent<AudioSource>();
        music.closePhone();
    }

    public void psychedelicacy(){
        music.setSong(0);
        //phoneMusic.Stop();
        phoneMusic.PlayOneShot(songs[0]);
    }

    public void sayHello(){
        music.setSong(1);
        //phoneMusic.Stop();
        phoneMusic.PlayOneShot(songs[1]);
    }

    public void funkSoWhat(){
        music.setSong(2);
        phoneMusic.Stop();
        phoneMusic.PlayOneShot(songs[2]);
    }

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

