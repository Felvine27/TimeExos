using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public float speed = 1.0F;

    public float lifeSpan = 15.0F;

    public static float bulletTime;

    public static bool touchedBullet;


    void Start()
    {
        
    }


    void Update()
    {

        gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);

        BulletTime();

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Triggered Enemy");
     
        bulletTime = 0.0F;

        touchedBullet = true;

        Destroy(gameObject);

    }

    public void BulletTime()
    {    

        if (touchedBullet && bulletTime < 1.0F)
        {
            Debug.Log("Slow motion");
            Manager.controlTime = 0.5F;
        }

        if (bulletTime > 1.0F)
        {
            Debug.Log("No more slow motion");
            touchedBullet = false;
            Manager.controlTime = 1.0F;
        }

        bulletTime += Time.unscaledDeltaTime;

    }

}
