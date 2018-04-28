using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float smoothTime = 0.3f;
    public float[] minMaxXAxis = new float[2] { -5, 5 };
    public float[] minMaxYAxis = new float[2] { -3, 3 };
    public float mouseSensitivity = 50.0f;
    private float xVelocity = 0.0f;
    private float yVelocity = 0.0f;
    private float x = 0;
    private float y = 0;
    private float xSmooth;
    private float ySmooth;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Update()
    {
        x -= Input.GetAxis("Mouse X") * mouseSensitivity * 0.02f;
        y -= Input.GetAxis("Mouse Y") * mouseSensitivity * 0.02f;

        if (y > minMaxYAxis[1]) y = minMaxYAxis[1];
        if (y < minMaxYAxis[0]) y = minMaxYAxis[0];
        if (x > minMaxXAxis[1]) x = minMaxXAxis[1];
        if (x < minMaxXAxis[0]) x = minMaxXAxis[0];

        xSmooth = Mathf.SmoothDamp(xSmooth, x, ref xVelocity, smoothTime);
        ySmooth = Mathf.SmoothDamp(ySmooth, y, ref yVelocity, smoothTime);

        Quaternion parallax = new Quaternion();
        parallax = Quaternion.Euler(ySmooth, xSmooth, 0);

        //this.transform.localPosition = new Vector3(xSmooth, ySmooth, 0f);
        this.transform.localRotation = parallax;
    }
}
