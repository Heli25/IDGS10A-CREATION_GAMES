using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTable2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        switch(tag)
        {
            case "Dead":
                GameManager2.instance.GameEnd();
                break;

            case "Bouncer":
                GameManager2.instance.UpdateScore(10, 1);
                break;

            case "Point":
                GameManager2.instance.UpdateScore(20, 1);
                break;

            case "Side":
                GameManager2.instance.UpdateScore(10, 0);
                break;

            case "Flipper":
                GameManager2.instance.multiplier = 1;
                break;

            default:
                break;
        }
    }
}
