using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    public GameObject map;
    public GameObject buttons;


    void Start(){
    }

    public void ShowMap()
    {
        map.SetActive(true);
        buttons.SetActive(false);
    }
    public void HideMap()
    {
        map.SetActive(false);
        buttons.SetActive(true);
    }
}
