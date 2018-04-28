using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : MonoBehaviour
{
	private void OnMouseDown()
	{
		FindObjectOfType<AudioManager> ().Play ("Horse");
		//Debug.Log ("Horse Sound");
	}
}