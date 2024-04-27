using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleButton : MonoBehaviour
{
    public Material alternativeMaterial;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Dedo")
        {
            Material currentMaterial = GetComponent<MeshRenderer>().material;
            GetComponent<MeshRenderer>().material = alternativeMaterial;
            alternativeMaterial = currentMaterial;
        }
    }
}
