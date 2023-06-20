using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    public GameObject map;
    public GameObject back;

    void Start(){
        map.SetActive(false);
        back.SetActive(false);
        
    }

    public void ShowMap()
    {
        map.SetActive(true);
        back.SetActive(true);
    }
    public void HideMap()
    {
        map.SetActive(false);
        back.SetActive(false);
    }
}
