using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dj : MonoBehaviour
{
	private void OnMouseDown()
	{
		FindObjectOfType<AudioManager> ().Play ("Dj2");
		//Debug.Log ("Dj Sound");
	}
}