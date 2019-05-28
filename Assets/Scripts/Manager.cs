using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{

    public static class Manager
    {

        public static float controlTime = 1.0F;

        public static bool isPaused;

        private static float timeStocked;

        public static void ControlTime()
        {
            Time.timeScale = controlTime;
        }

        public static void Pause()
        {

            if (isPaused)
                isPaused = !isPaused;

            if (isPaused)
            {

                timeStocked = Time.timeScale;

                Time.timeScale = 0.0F;

            }
            else
            {
                Time.timeScale = timeStocked;
            }

        }

    }
}
