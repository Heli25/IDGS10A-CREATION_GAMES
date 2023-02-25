using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Highscores : MonoBehaviour
{
    [SerializeField] private string high = "Highscores";

    public void NewGameButton(){
        SceneManager.LoadScene(high);
    }
}