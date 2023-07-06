//the Commuters class handles the spawning of commuters

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commuters : MonoBehaviour
{
    public float chancenum;

    public GameObject triangle; 
    public GameObject helpObj;
    public GameObject ignoreObj;

    public float timer;

    public int asshole;

    public bool talking;

    // Start is called before the first frame update
    void Start()
    {
        triangle.SetActive(false);
        helpObj.SetActive(false);
        ignoreObj.SetActive(false);

        timer = 10.0f;
        talking = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        if (timer <= 0 && !talking){    //every 10 seconds there is a 2/6 chance a commuter will appear (while a commuter is not present)
            if (chance() <= 1.0f){
                talking = true; // make talking A METHOD to activate everything, dont put all here 
                //add asshole level and angel level to compare @ end
                triangle.SetActive(true);
                helpObj.SetActive(true);
                ignoreObj.SetActive(true);
                Debug.Log("commuter");
            }
            else{
                reset();
            }
        }

        
    }

    public void reset(){    // resets timer and clears canvas
        timer = 10.0f;
        triangle.SetActive(false);
        helpObj.SetActive(false);
        ignoreObj.SetActive(false);
    }

    public float chance(){  // generates a random number to determine if a commuter has appeared
        chancenum = Mathf.Round(Random.Range(0.0f, 5.0f));
        return chancenum;
    }

    public void help(){     // results if the player helps the commuter
        asshole -= 1;
        Debug.Log("asshole level: " + asshole);
        talking = false;
        reset();
    }

    public void ignore(){   // results if the player ignores the commuter
        asshole += 1;
        Debug.Log("asshole level: " + asshole);
        talking = false;
        reset();
    }
}
