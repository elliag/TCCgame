// handMove class attaches the hand sprite to the mouse coords while the player is interacting with the phone component

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class handMove : MonoBehaviour
{
    public GameObject hand;

    void Update(){
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        hand.transform.position = mousePosition;
    }
}