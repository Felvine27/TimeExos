using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsPlayer : MonoBehaviour
{


    void Start()
    {
        
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Manager.Pause();

            Manager.controlTime = 0.0F;

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {

            Manager.Pause();

            Manager.controlTime = 1.0F;

        }

    }
}
