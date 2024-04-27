using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditor.Rendering;
using UnityEngine;

public class Swat : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float fireDistance;
    public float followDistance;
    public float distance;
    
    
    void Update()
    {
        distance = (target.position - transform.position).magnitude;
        GetComponentInChildren<Animator>().SetFloat("Distance", distance);
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        if (distance < followDistance && distance > fireDistance)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        } else if (distance < fireDistance)
        {
            //TODO: Fire
        }
    }
}
