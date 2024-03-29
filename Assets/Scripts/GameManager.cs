using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour   
{
    [SerializeField]
    GameObject ball,startButton,scoreText,menuButton,restartButton,pauseButton, resumeButton, pauseBackground;

    int score;

    /*[SerializeField]
    private float initialVelocity = 10f;*/

    [SerializeField]
    Rigidbody2D left, right;

    [SerializeField]
    Vector3 startPos;

    public int multiplier;

    private Vector2 launchDirection;

    bool canPlay;
    //bool ballLaunched = false;

    public static GameManager instance;

    // Referencia al componente TextMeshProUGUI
    public TextMeshProUGUI text;

    // Array de posibles textos
    public string[] RandomText = new string[]{ 
                                              "Power: Good job knave but not as good as me",
                                              "Denji: U good at this dude but the powerful chainsaw man is better",
                                              "Aki: You might last as a devil hunter at this rate",
                                              "Makima: You will do an interesting pet"};
    private float textChangeInterval = 5f;
    private float timeSinceLastTextChange = 0f;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Time.timeScale = 1;
        score = 0;
        multiplier = 1;
        canPlay = false;
    }

    private void Update()
    {
        if (!canPlay) return;
        
        /*if (!ballLaunched && Input.GetKeyDown(KeyCode.Space))
        {
            ballLaunched = true;
            LaunchBall();
        }*/

        if(Input.GetKey(KeyCode.A))
        {
            left.AddTorque(90f);
        }
        else
        {
            left.AddTorque(-85f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            right.AddTorque(-90f);
        }
        else
        {
            right.AddTorque(85f);
        }

    timeSinceLastTextChange += Time.deltaTime;
    if (timeSinceLastTextChange >= textChangeInterval)
    {
        ChangeText();
        timeSinceLastTextChange = 0f;
    }

    }

    public void UpdateScore(int point, int mullIncrease)
    {
        multiplier += mullIncrease;
        score += point * multiplier;
        scoreText.GetComponent<TextMeshProUGUI>().text = " " + score;
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        menuButton.SetActive(true);
        restartButton.SetActive(true);
        resumeButton.SetActive(true);
        pauseBackground.SetActive(true);
        pauseBackground.transform.Find("GamePaused").GetComponent<TextMeshProUGUI>().enabled = true;
        pauseBackground.transform.Find("GameOver").GetComponent<TextMeshProUGUI>().enabled = false;

    }

    public void Resume()
    {
        Time.timeScale = 1;
        menuButton.SetActive(false);
        restartButton.SetActive(false);
        resumeButton.SetActive(false);
        pauseBackground.SetActive(false);
    }

    public void GameEnd()
    {
        Time.timeScale = 0;
        menuButton.SetActive(true);
        restartButton.SetActive(true);
        pauseBackground.SetActive(true);
        pauseBackground.transform.Find("GameOver").GetComponent<TextMeshProUGUI>().enabled = true;
        pauseBackground.transform.Find("GamePaused").GetComponent<TextMeshProUGUI>().enabled = false;
    }

    public void GameStart()
    {
        startButton.SetActive(false);
        scoreText.SetActive(true);
        Instantiate(ball, startPos, Quaternion.identity);
        /*GameObject newBall = Instantiate(ball, startPos, Quaternion.identity);
        Rigidbody2D ballRb = newBall.GetComponent<Rigidbody2D>();
        ballRb.gravityScale = 0;
        LaunchBall();
        ballRb.AddForce(launchDirection * initialVelocity, ForceMode2D.Impulse);*/
        canPlay = true;
        ChangeText();
    }

    public void GameRestart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }

    public void GameQuit()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    void ChangeText()
    {
        // Seleccionamos un texto aleatorio del array posiblesTextos
        string newText = RandomText[Random.Range(0, RandomText.Length)];
        // Actualizamos el contenido del componente TextMeshProUGUI
        text.text = newText;
        Invoke("ChangeText", 5f);
    }

   /*public void LaunchBall()
    {
        // lanzar la bola
        Rigidbody2D ballRb = ball.GetComponent<Rigidbody2D>();
        ballRb.velocity = new Vector2(0f, 25f);
    }*/
}
