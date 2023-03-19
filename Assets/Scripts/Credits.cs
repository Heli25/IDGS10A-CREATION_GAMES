using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

    public float speed = 1f; // adjust the scrolling speed

    void Start () {
        Invoke("Exit", Random.Range(5f, 10f)); // call Exit() function after 5 to 10 seconds
    }

    void Update () {
        transform.Translate(Vector3.up * speed * Time.deltaTime); // move text object up the screen
    }

    void Exit() {
        Application.Quit(); // quit the application
    }
}
