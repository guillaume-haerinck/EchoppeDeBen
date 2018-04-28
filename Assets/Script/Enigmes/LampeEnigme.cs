using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampeEnigme : MonoBehaviour
{
	public float nbClick = 1f;
    private bool bResolved = false;

	private void OnMouseDown()
	{
        if (!bResolved)
        {
            if (nbClick < 5f)
            {
                nbClick = nbClick + 1f;
                FindObjectOfType<AudioManager>().Play("CorkPull");
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("Ok1");
                Debug.Log("Enigme ampoule resolue");
                bResolved = true;
                GameManager.instance.EnigmaResolved();
            }
        }
	}
}