using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwatFire : MonoBehaviour
{
    public GameObject prefabEffect;
    public Transform spawnPointEffect;
    public void Fire()
    {
        Instantiate(prefabEffect, spawnPointEffect.position, spawnPointEffect.rotation);
    }
}
