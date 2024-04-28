using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorLanzador : MonoBehaviour
{
    public LanzadorObjetos lanzadorObjetos;
    public Material activatedMaterial;
    private Material originalMaterial;
    private void Start()
    {
        originalMaterial = GetComponent<MeshRenderer>().material;
        if (activatedMaterial == null ) 
        {
            activatedMaterial = originalMaterial;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lanzadorObjetos.StartLanzamientos();
            GetComponent<MeshRenderer>().material = activatedMaterial;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lanzadorObjetos.StopLanzamientos();
            GetComponent<MeshRenderer>().material = originalMaterial;
        }
    }
}
