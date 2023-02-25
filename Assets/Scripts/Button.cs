using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
     [SerializeField] private string menu = "Main menu";

    public void NewGameButton(){
        SceneManager.LoadScene(menu);
    }
}
