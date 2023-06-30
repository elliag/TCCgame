using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class Notes : MonoBehaviour
{
    public TMP_Text titleText;
    public TMP_Text noteText;

    public bool which;

    // Start is called before the first frame update
    void Start()
    {
        which = true; // true for title
    }

    // Update is called once per frame
    void Update()
    {
        if (which){
            foreach (char c in Input.inputString)
            {
                if (c == '\b') // has backspace/delete been pressed?
                {
                    if (titleText.text.Length != 0)
                    {
                        titleText.text = titleText.text.Substring(0, titleText.text.Length - 1);
                    
                    }
                }
                else if ((c == '\n') || (c == '\r')) // enter/return
                {
                    which = false;
                }
                else
                {
                    titleText.text += c;
                }
            }
        }
        else{
            foreach (char c in Input.inputString)
            {
                if (c == '\b') // has backspace/delete been pressed?
                {
                    if (noteText.text.Length != 0)
                    {
                        noteText.text = noteText.text.Substring(0, noteText.text.Length - 1);
                    
                    }
                }
                else if ((c == '\n') || (c == '\r')) // enter/return
                {
                    noteText.text = Environment.NewLine;
                }
                else
                {
                    noteText.text += c;
                }
            }
        }
    }

    public void title(){
        which = true;
    }

    public void note(){
        which = false;
    }
}
