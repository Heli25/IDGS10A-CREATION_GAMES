using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Board2 : MonoBehaviour
{
    [SerializeField] private string play = "Gameplay";

    public void NewGameButton(){
        SceneManager.LoadScene(play);
    }
}
