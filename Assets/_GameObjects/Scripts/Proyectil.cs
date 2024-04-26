using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public string enemyTag = "Enemigo";
    public GameObject prefabEnemyCollision;
    public GameObject prefabOtherCollision;

    
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag(enemyTag))
        {
            GameObject.Find("GameManager")?.GetComponent<GameManager>()?.RemoveEnemy();
            Instantiate(prefabEnemyCollision, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        } else {
            Instantiate(prefabOtherCollision, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
