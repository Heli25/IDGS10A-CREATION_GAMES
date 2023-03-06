using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        switch(tag)
        {
            case "Dead":
                GameManager.instance.GameEnd();
                break;

            case "Circle":
                GameManager.instance.UpdateScore(10, 1);
                break;

            case "Zorro":
                GameManager.instance.UpdateScore(20, 1);
                break;

            case "Horn":
                GameManager.instance.UpdateScore(10, 0);
                break;

            case "Flipper":
                GameManager.instance.multiplier = 1;
                break;

            default:
                break;
        }
    }
}
