using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastWeapon : MonoBehaviour
{
    public Transform raycastOrigin;
    public Material hitMaterial;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire(){
        Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out RaycastHit hitInfo);
        Renderer renderer = hitInfo.collider.gameObject.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = hitMaterial;
        }
    }
}
