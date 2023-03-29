using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelector : MonoBehaviour
{
    public Image[] selection;
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        this.Select(0);
    }

    public void Select(int index)
    {
        this.selection[index].gameObject.SetActive(true);
        PlayerStorage.playerPrefab = this.prefabs[index];
    }
}
