using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private string start = "Game";

    public void NewGameButton(){
        SceneManager.LoadScene(start);
    }
}