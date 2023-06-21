using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


using TMPro;
using System;

public class WhichPlatform : MonoBehaviour
{
    public SceneChanger chooseDirection;
    public string direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = chooseDirection.getDirection();
    }

    public void platform(){

        if(String.Equals(direction, "Eastbound")){
            chooseDirection.LoadEastPlatform();
        }
        else if(String.Equals(direction, "Westbound")){
            chooseDirection.LoadWestPlatform();
        }
    }
}
