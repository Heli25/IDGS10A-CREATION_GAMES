using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleScript : MonoBehaviour
{
    public Transform characterSpawnPoint;

    private void Start()
    {
        GameObject selectedCharacterInstance = Instantiate(CharacterSelection.selectedCharacter, characterSpawnPoint.position, characterSpawnPoint.rotation);
    }
}
