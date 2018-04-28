using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public float reduceSizeAmount = 0.95f;

    private float distance = 10;
    private Vector3 originalScale;
    private Vector3 originalPos;

    private void Start()
    {
        originalScale = this.transform.localScale;
        originalPos = this.transform.localPosition;
    }

    private void OnMouseEnter()
    {
        this.transform.localScale *= reduceSizeAmount;
    }

    private void OnMouseExit()
    {
        this.transform.localScale = originalScale;
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    private void OnMouseUp()
    {
        this.transform.localPosition = originalPos;
    }

}
