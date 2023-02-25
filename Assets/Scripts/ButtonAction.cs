using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
    [SerializeField] private string control = "Controls";

    public void NewGameButton(){
        SceneManager.LoadScene(control);
    }
}
