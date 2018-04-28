using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeuxMove : MonoBehaviour
{

    // reference is a game object used for the calculation. 
    // It cannot be the game object with the moving eye, 
    // and it cannot be a child of the eye, but if the face moves,
    // it must be a child of the face.
    public Transform reference;
    public float factor = 0.25f;
    public float limit = 0.08f;

    private Vector3 center;

    void Start()
    {
        center = transform.position;
    }

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0.0f;
        Vector3 dir = (pos - reference.position) * factor;
        dir = Vector3.ClampMagnitude(dir, limit);
        transform.position = center + dir;
    }
}
