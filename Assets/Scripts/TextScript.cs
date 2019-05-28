using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{

    //

    public Text myText;

    public float timeToWait = 2.0F;

    public float elapsedTime = 0.0F;

    public float elapsedTime2 = 0.0F;

    public float lastTime = 0.0F;

    public float lastTime2 = 0.0F;

    public float nextTime = 0.0F;

    void Start()
    {
        


    }


    void Update()
    {

        ResetScene();

        ChangeTimeScale();

        myText.text = "Time: " + Time.time;

        myText.text += "\nDelta time :  " + Time.deltaTime;

        myText.text += "\nFixed Delta time :  " + Time.fixedDeltaTime;

        myText.text += "\nReal Time since startup:  " + Time.realtimeSinceStartup;

        myText.text += "\nTime since level load:  " + Time.timeSinceLevelLoad;

        myText.text += "\nTime scale:  " + Time.timeScale;

        myText.text += "\nUnscaled Time:  " + Time.unscaledTime;

        myText.text += "\nUnscaled Delta time:  " + Time.unscaledDeltaTime;

        myText.text += "\nFixed unscaled Delta time:  " + Time.fixedUnscaledDeltaTime;

        myText.text += "\nSmooth Delta time:  " + Time.smoothDeltaTime;

        myText.text += "\nFrame count:  " + Time.frameCount;

        myText.text += "\nElapsed time:  " + elapsedTime;

        myText.text += "\nElapsed time 2:  " + elapsedTime2;

        myText.text += "\nLast time:  " + lastTime;

        myText.text += "\nLast time 2:  " + lastTime2;


        //

        ElapsedTimeFunction();

        //

        LastTimeFunction();

    }


    private void FixedUpdate()
    {
        
        

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
            nextTime = Time.time + timeToWait;

    }

    public void ResetScene()
    {

        if (Input.GetKeyDown(KeyCode.A))
            SceneManager.LoadScene(0);

    }

    public void ChangeTimeScale()
    {

        if (Input.GetKeyDown(KeyCode.E))
            Time.timeScale = Time.timeScale * 2;

        if (Input.GetKeyDown(KeyCode.Z))
            Time.timeScale = Time.timeScale / 2;

        if (Input.GetKeyDown(KeyCode.Space))
            Time.timeScale = 0.0F;

        if (Input.GetKeyUp(KeyCode.Space))
            Time.timeScale = 1.0F;

    }

}
