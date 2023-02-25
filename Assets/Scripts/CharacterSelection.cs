using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;
    public GameObject character5;

    public static GameObject selectedCharacter;

    public void SelectCharacter1()
    {
        selectedCharacter = character1;
    }

    public void SelectCharacter2()
    {
        selectedCharacter = character2;
    }

    public void SelectCharacter3()
    {
        selectedCharacter = character3;
    }

    public void SelectCharacter4()
    {
        selectedCharacter = character4;
    }

    public void SelectCharacter5()
    {
        selectedCharacter = character5;
    }

    public void ContinueButton()
    {
        SceneManager.LoadScene("Game");
    }
}

