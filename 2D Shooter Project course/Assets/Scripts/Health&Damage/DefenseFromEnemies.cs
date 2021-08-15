using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseFromEnemies : MonoBehaviour
{

    [Tooltip("Prefab to spawn after doing damage")]
    public GameObject hitEffect = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //check, if gameobject has tag EnemyProjectile
        if (other.tag == "EnemyProjectile")
        {
            //delete EnemyProjectile gameobject from the scene
            Destroy(other.gameObject);

            Instantiate(hitEffect, other.transform.position, other.transform.rotation, null);
        }
    }
}
