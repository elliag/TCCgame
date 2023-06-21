using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class LineBPlatform : MonoBehaviour
{

    public TMP_Text direction_text;

    public TMP_Text station;

    public SceneChanger drawDirection;

    public string test;


    // Start is called before the first frame update
    void Start()
    {
        direction_text.text = drawDirection.getDirection();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

}
