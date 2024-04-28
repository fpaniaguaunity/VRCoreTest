using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SwatFire : MonoBehaviour
{
    public GameObject prefabEffect;
    public Transform spawnPointEffect;
    public Transform eyesOrigin;

    public void Fire()
    {
        if (PlayerInSight())
        {
            Instantiate(prefabEffect, spawnPointEffect.position, spawnPointEffect.rotation);
        }


    }
    bool PlayerInSight()
    {
        Physics.Raycast(eyesOrigin.position, eyesOrigin.forward, out RaycastHit hitInfo);
        if (hitInfo.collider != null && hitInfo.collider.CompareTag("Player"))
        {
            return true;
        }
        return false;
    }
}
