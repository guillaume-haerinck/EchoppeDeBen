using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Put this script on 3 gameobject
// change the public digit for each
// if they are clicked on the right order
// the enigma is won.

public class RadioEnigme : MonoBehaviour
{
    public int digit = 1;

    private static int[] solution = new int[3] { 1, 2, 3 };
    private static int[] input = new int[3] { -1, -1, -1 };
    private bool bResolved = false;

    void OnMouseDown()
    {
        //Debug.Log("radio click");

        input[0] = input[1];
        input[1] = input[2];
        input[2] = digit;

        if (!bResolved)
        {
            if (solution[0] == input[0] && solution[1] == input[1] && solution[2] == input[2])
            {
                Debug.Log("Enigme radio réussie");
                FindObjectOfType<AudioManager>().Play("Ok1");
                bResolved = true;
                GameManager.instance.EnigmaResolved();
            }
        }
    }
}
