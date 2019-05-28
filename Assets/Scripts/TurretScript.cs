using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurretScript : MonoBehaviour
{

    public GameObject preFabs;

    public float timeToWait = 1.0F;

    public float elapsedTime = 0.0F;

    public float elapsedTime2 = 0.0F;

    public float lastTime = 0.0F;

    public float lastTime2 = 0.0F;

    public float nextTime = 0.0F;

    public float bulletTime = 3.0F;

    public float timeScaled;

    void Start()
    {


    }


    public void Update()
    {

        preFabs.GetComponent<PewPewScript>().lifeTime = bulletTime;

        InstanciatePewPew();

    }

    public void InstanciatePewPew()
    {
     
        ElapsedTimeFunction();
        LastTimeFunction();

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
            
        if (Time.time >= nextTime)
        {
            Instantiate(preFabs, gameObject.transform.position, gameObject.transform.rotation);
            nextTime = Time.time + timeToWait;
        }
            

    }

    public void ResetScene()
    {

        if (Input.GetKeyDown(KeyCode.A))
            SceneManager.LoadScene(0);

    }

    //public void ChangeTimeScale()
    //{

    //    if (Input.GetKeyDown(KeyCode.E))
    //        Time.timeScale = Time.timeScale * 2;

    //    if (Input.GetKeyDown(KeyCode.Z))
    //        Time.timeScale = Time.timeScale / 2;

    //    //if (Input.GetKeyDown(KeyCode.Space))
    //    //{

    //    //    Manager.Pause();

    //    //    //timeScaled = Time.timeScale;

    //    //    Manager.controlTime = 0.0F;

    //    //    //Manager.isPaused = true;

    //    //}
            
    //    //if (Input.GetKeyUp(KeyCode.Space))
    //    //{

    //    //    Manager.Pause();

    //    //    //Manager.controlTime = 1.0F;
    //    //    //Manager.controlTime = timeScaled;
    //    //    //Manager.isPaused = false;

    //    //}


    //}

}
