using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackInteractiveObject : MonoBehaviour
{
    // ------------- SHAKING -----------------
    // How long the object should shake for.
    public float shakeDurationMax = 0.15f;
    private float shakeDuration;

    // Amplitude of the shake. A larger value shakes the camera harder.
    public float shakeAmount = 0.11f;
    private float decreaseFactor = 1.0f;

    private Vector3 originalPos;
    private bool bIsShaking = false;

    // ------------- SCALE --------------
    public float reduceSizeAmount = 0.9f;
    private Vector3 originalScale;

    private void Start()
    {
        shakeDuration = shakeDurationMax;
        originalPos = this.transform.localPosition;
        originalScale = this.transform.localScale;
    }

    void Update ()
    {
        if (bIsShaking)
        {
            if (shakeDuration > 0f)
            {
                this.transform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
                shakeDuration -= Time.deltaTime * decreaseFactor;
            }
            else
            {
                this.transform.localPosition = originalPos;
                bIsShaking = false;
            }
        }
    }

    private void OnMouseOver()
    {
        //Debug.Log("Souris au dessus");
        bIsShaking = true;
    }

    private void OnMouseExit()
    {
        shakeDuration = shakeDurationMax;
    }

    private void OnMouseDown()
    {
        //Debug.Log("Objet clické !");
        this.transform.localScale *= reduceSizeAmount;
    }

    private void OnMouseUp()
    {
        this.transform.localScale = originalScale;
    }
}