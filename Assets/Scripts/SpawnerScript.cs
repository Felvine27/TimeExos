using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public GameObject preFab;

    public float spawnTime;


    void Start()
    {
        
    }


    void Update()
    {

        spawnTime += Time.deltaTime;
        
        if(spawnTime > 3.0F)
        {
            Instantiate(preFab, gameObject.transform.position, gameObject.transform.rotation);
            spawnTime =  0.0F;
        }

    }
}
