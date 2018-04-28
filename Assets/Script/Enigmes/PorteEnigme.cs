using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteEnigme : MonoBehaviour
{
    public float maxTimer = 4f;

    private int maxCount = 4;
    private int counter;
    private float timer;
    private bool bTimerOn;
    private bool bResolved = false;

    private void Start()
    {
        counter = 0;
        timer = maxTimer;
        bTimerOn = false;
    }

    private void Update()
    {
        if (bTimerOn)
        {
            timer -= Time.deltaTime;
            if (timer < 0f)
            {
                Debug.Log("Porte: temps écoulé !");
                counter = 0;
                timer = maxTimer;
                bTimerOn = false;
            }
        }
    }

    private void OnMouseDown()
    {
        if (!bResolved)
        {
            bTimerOn = true;
            counter++;
            //Debug.Log("counter porte = " + counter);

            if (counter == 1)
            {
                FindObjectOfType<AudioManager>().Play("Knock1");
            }
            else if (counter == 2)
            {
                FindObjectOfType<AudioManager>().Play("Knock2");
            }
            else if (counter == 3)
            {
                FindObjectOfType<AudioManager>().Play("Knock3");
            }
            else if (counter == 4)
            {
                FindObjectOfType<AudioManager>().Play("Knock4");
            }
            else if (counter >= maxCount)
            {
                Debug.Log("Enigme de la porte réussie");
                bResolved = true;
                GameManager.instance.EnigmaResolved();
				FindObjectOfType<AudioManager>().Play("Ok1");
            }
        }
    }
}