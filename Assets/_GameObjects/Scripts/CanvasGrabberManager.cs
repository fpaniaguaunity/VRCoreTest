using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGrabberManager : MonoBehaviour
{
    public GameObject canvasGrabbable;
    public Vector3 originalPosition;
    public Quaternion  originalRotation;
    public Vector3 originalScale;
    public void Start()
    {
        originalPosition = canvasGrabbable.transform.localPosition;
        originalRotation = canvasGrabbable.transform.localRotation;
        originalScale = canvasGrabbable.transform.localScale;
    }

    public void Release()
    {
        canvasGrabbable.transform.localPosition = originalPosition;
        canvasGrabbable.transform.localRotation = originalRotation;
        canvasGrabbable.transform.localScale = originalScale;
    }
}
