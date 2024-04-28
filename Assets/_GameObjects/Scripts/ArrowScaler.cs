using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScaler : MonoBehaviour
{
    public float speed;

    void Update()
    {
        float scale = Mathf.Abs(Mathf.Cos(Time.realtimeSinceStartup));
        transform.localScale = new Vector3(1 + scale, 1 + scale, 1);
    }
}
