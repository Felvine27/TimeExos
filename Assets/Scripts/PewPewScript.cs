using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPewScript : MonoBehaviour
{

    public float speed = 2.0F;

    public float lifeTime = 20.0F;

    public float timeToWait = 1.0F;

    public float elapsedTime = 0.0F;

    public float elapsedTime2 = 0.0F;

    public float lastTime = 0.0F;

    public float lastTime2 = 0.0F;

    public float nextTime = 0.0F;

    public float bulletTime;

    bool touchedBullet;


    void Start()
    {

        Destroy(gameObject, lifeTime);

    }


    public void Update()
    {

        gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);

    }

    public void ElapsedTimeFunction()
    {

        elapsedTime += Time.deltaTime;

        elapsedTime2 += Time.deltaTime;

        if (elapsedTime > timeToWait)
            elapsedTime = 0.0F;

        if (elapsedTime2 > timeToWait)
            elapsedTime2 -= timeToWait;

    }

    public void LastTimeFunction()
    {
        if (lastTime + timeToWait < Time.time)
            lastTime = Time.time;

        if (lastTime2 + timeToWait < Time.time)
            lastTime2 = lastTime2 + timeToWait;


        if (Time.time >= nextTime)
        {
            nextTime = Time.time + timeToWait;
        }


    }

}
