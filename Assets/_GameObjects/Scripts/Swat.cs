using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditor.Rendering;
using UnityEngine;

public class Swat : MonoBehaviour
{
    public float walkSpeed;
    public float runSpeed;
    public float fireDistance;
    public float walkDistance;
    public float runDistance;
    public AudioClip stepSound;
    private AudioSource stepAudioSource;
    private float distance;
    private Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        stepAudioSource = GetComponent<AudioSource>();
        if (stepAudioSource != null)
        {
            stepAudioSource.clip = stepSound;
        }
    }

    void Update()
    {
        distance = (target.position - transform.position).magnitude;
        GetComponentInChildren<Animator>().SetFloat("Distance", distance);
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        if (distance < runDistance && distance > walkDistance)
        {
            transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
            if (!stepAudioSource.isPlaying)
            {
                stepAudioSource.Play();
            }
        }
        else if (distance < walkDistance && distance > fireDistance)
        {
            transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
            if (!stepAudioSource.isPlaying)
            {
                stepAudioSource.Play();
            }
        }
        else
        {
            StopStepSound();
        }
    }
    void PlayWalkStepSound()
    {
        stepAudioSource.Play();
    }
    void PlayRunStepSound()
    {
        stepAudioSource.Play();
    }
    void StopStepSound()
    {
        stepAudioSource.Stop();
    }

}
