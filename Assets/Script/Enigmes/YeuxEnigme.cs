using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Place this script on 3 object with collider,
// If the collisions happens in the right order two times
// the enigma is won.

public class YeuxEnigme : MonoBehaviour
{
    public int digit = 1;

    private static int[] solution = new int[3] { 1, 2, 3 };
    private static int[] input = new int[3] { -1, -1, -1 };
    private int count = 0;
    private bool bResolved = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collider eye");

        input[0] = input[1];
        input[1] = input[2];
        input[2] = digit;

        if (solution[0] == input[0] && solution[1] == input[1] && solution[2] == input[2])
        {
            //Debug.Log("Eyes bonne combinaison");
            count++;
            if (count >= 3)
            {
                if (!bResolved)
                {
                    Debug.Log("Enigme des yeux réussie");
                    count = 0;
                    bResolved = true;
					FindObjectOfType<AudioManager>().Play("Ok1");
                    GameManager.instance.EnigmaResolved();
                }
            }
        }
    }
}
