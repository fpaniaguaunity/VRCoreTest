using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditor.Rendering;
using UnityEngine;

public class Swat : MonoBehaviour
{
    public Transform target;
    public float walkSpeed;
    public float runSpeed;
    public float fireDistance;
    public float walkDistance;
    public float runDistance;
    public float distance;


    void Update()
    {
        distance = (target.position - transform.position).magnitude;
        GetComponentInChildren<Animator>().SetFloat("Distance", distance);
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        if (distance < runDistance && distance > walkDistance)
        {
            transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
        }
        else if (distance < walkDistance && distance > fireDistance)
        {
            transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
        }
        else if (distance < fireDistance)
        {
            //TODO: Fire
        }
    }
}
