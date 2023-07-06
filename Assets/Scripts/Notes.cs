//Notes class controls the notes app on the Phone, displays keyboard input on the screen

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
        which = true; // bool to identify if the player is typing in the Title or Body of the note (true for Title)
    }

    // Update is called once per frame
    void Update()
    {
        if (which){
            foreach (char c in Input.inputString)
            {
                if (c == '\b') // backspace
                {
                    if (titleText.text.Length != 0)
                    {
                        titleText.text = titleText.text.Substring(0, titleText.text.Length - 1);
                    }
                }
                else if ((c == '\n') || (c == '\r')) // enter button switches from title to body
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
                if (c == '\b') // backspace
                {
                    if (noteText.text.Length != 0)
                    {
                        noteText.text = noteText.text.Substring(0, noteText.text.Length - 1);
                    }
                }
                else if ((c == '\n') || (c == '\r')) // enter
                {
                    noteText.text = noteText.text + Environment.NewLine;
                }
                else
                {
                    noteText.text += c;
                }
            }
        }
    }

    public void title(){    // switches typing to the title
        which = true;
    }

    public void note(){     // switches typing to the body
        which = false;
    }
}
