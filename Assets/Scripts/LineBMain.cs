using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBMain : MonoBehaviour
{
    public GameObject map;    //map canvas
    public GameObject buttons;

    // Start is called before the first frame update
    void Start()
    {
        map.SetActive(false);
        buttons.SetActive(true);
    }




}
