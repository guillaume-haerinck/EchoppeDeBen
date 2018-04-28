using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClefMachineAEcrire : MonoBehaviour
{
    public GameObject key;
    public GameObject SpawnPos;

    private void OnMouseDown()
    {
        Instantiate(key, SpawnPos.transform);
    }

}
