using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMusicButton : MonoBehaviour
{
   private Audio audioManager;

    private void Start()
    {
        audioManager = GameObject.FindObjectOfType<Audio>();
        DontDestroyOnLoad(this.gameObject);
    }

    public void OnClickPauseButton()
    {
        if (audioManager != null)
        {
            audioManager.ToggleMusic();
        }
    }
}
