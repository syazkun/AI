using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
     if (other.gameObject.tag == "Player")
     {
      EnemySpawner();
      Destroy (gameObject, 1);
      gameObject.GetComponent<BoxCollider>().enabled = false;
     }

    }

    void EnemySpawner()
    {
     Instantiate (enemy, enemyPos.position, enemyPos.rotation);
    }

}
