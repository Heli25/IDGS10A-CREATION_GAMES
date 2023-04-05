using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Board1 : MonoBehaviour
{
   [SerializeField] private string play = "Game";

    public void NewGameButton(){
        SceneManager.LoadScene(play);
    }
}
