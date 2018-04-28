using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
	private void OnMouseDown()
	{
			FindObjectOfType<AudioManager> ().Play ("Radio");
			//Debug.Log ("Radio Sound");
	}
}