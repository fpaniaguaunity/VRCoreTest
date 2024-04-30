using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastWeapon : MonoBehaviour
{
    public Transform raycastOrigin;
    public Material hitMaterial;


    public void Fire(){
        Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out RaycastHit hitInfo);
        
        if (hitInfo.collider.CompareTag("Enemigo")){
            //hacer lo que sea 
        } else if (hitInfo.collider.CompareTag("Amigo")){
            //Lo que sea
        } else {
            //Lo que sea
        }

        
        //Parte del cambio de material
        Renderer renderer = hitInfo.collider.gameObject.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = hitMaterial;
        }
    }
}
