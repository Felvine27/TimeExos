using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RafaleTurretScript : TurretScript
{

    public float timeBetween;

    int nbBullets;

    public int nbBulletsRow = 3;

    bool rafaleShoot;

    void Start()
    {

        

    }

    public new void Update()
    {

        preFabs.GetComponent<PewPewScript>().lifeTime = bulletTime;

        // Manager.ControlTime();

        RafaleShot();

    }

    public void RafaleShot()
    {

        timeBetween += Time.deltaTime;

        if (Time.time >= nextTime)
        {

            rafaleShoot = true;

            nextTime = Time.time + timeToWait;

        }

        if (rafaleShoot)
        {

            if (timeBetween > 0.5F && nbBullets < nbBulletsRow)
            {

                Instantiate(preFabs, gameObject.transform.position, gameObject.transform.rotation);
                timeBetween = 0.0F;
                nbBullets++;

                if (nbBullets == nbBulletsRow)
                {
                    nbBullets = 0;
                    rafaleShoot = false;
                }

            }

        }

    }


}
