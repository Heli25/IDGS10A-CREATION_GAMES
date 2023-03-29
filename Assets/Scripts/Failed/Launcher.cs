using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] KeyCode launchKey = KeyCode.Space;

    void Update()
    {
        /*if (Input.GetKeyDown(launchKey))
        {
            GameManager.instance.LaunchBall();
        }*/
    }
}
