//MapDisplay contains methods to control opening and closing the map canvas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    public GameObject map;
    public GameObject buttons;

    public void ShowMap()
    {
        map.SetActive(true);    //opens map canvas
        buttons.SetActive(false);   //disables UI buttons in the background
    }
    public void HideMap()
    {
        map.SetActive(false);
        buttons.SetActive(true);
    }
}
