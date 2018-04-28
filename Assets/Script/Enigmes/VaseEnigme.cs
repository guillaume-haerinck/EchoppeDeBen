using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseEnigme : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Sol")
        {
			FindObjectOfType<AudioManager>().Play("Vase");
			FindObjectOfType<AudioManager>().Play("Ok1");
			Destroy (gameObject);
			Debug.Log ("Vase détruit");
            GameManager.instance.EnigmaResolved();
		}
	}
}
