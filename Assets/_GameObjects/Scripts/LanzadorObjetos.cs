using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzadorObjetos : MonoBehaviour
{
    public Transform puntoLanzamiento;
    public List<GameObject> prefabsObjetos;
    public float fuerza;
    public float tiempoEntreLanzamientos = 5;
    public void StartLanzamientos()
    {
        InvokeRepeating("Lanzar", tiempoEntreLanzamientos, tiempoEntreLanzamientos);
    }
    public void StopLanzamientos()
    {
        CancelInvoke("Lanzar");
    }
    void Lanzar()
    {
        GameObject gameObject = Instantiate(prefabsObjetos[Random.Range(0, prefabsObjetos.Count)], puntoLanzamiento.position, puntoLanzamiento.rotation);
        gameObject.GetComponent<Rigidbody>().AddForce(puntoLanzamiento.forward * fuerza, ForceMode.Force);
    }
}
