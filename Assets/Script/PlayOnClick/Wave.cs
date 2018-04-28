using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
	private void OnMouseDown()
	{
		FindObjectOfType<AudioManager> ().Play ("Wave");
		//Debug.Log ("Wave Sound");
	}
}