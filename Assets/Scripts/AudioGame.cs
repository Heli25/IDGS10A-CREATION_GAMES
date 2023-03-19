using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioGame : MonoBehaviour
{
    public Image image;
    public Sprite sprite1;
    public Sprite sprite2;
    public AudioSource audioSource;

    private bool isPaused = false;

   public void PauseMusic()
{
    if (image != null)
    {
        image.sprite = sprite2; // Cambia el sprite
    }
    audioSource.Pause(); // Pausa el sonido
    isPaused = true;
}


public void PlayMusic()
{
    if (!isPaused) // Si el audio no ha sido pausado previamente, empieza la reproducción
    {
        image.sprite = sprite1; // Cambia el sprite
        audioSource.Play(); // Reproduce el sonido
    }
    else // Si el audio ha sido pausado previamente, reanuda la reproducción
    {
        image.sprite = sprite1; // Cambia el sprite de vuelta al original
        audioSource.UnPause(); // Reanuda la reproducción del sonido
        isPaused = false; // Actualiza el estado del audio
    }
}

public void ToggleMusic()
{
    if (audioSource.isPlaying) // Si la música está sonando, pausa la reproducción
    {
        PauseMusic();
    }
    else // Si la música no está sonando, inicia o reanuda la reproducción
    {
        PlayMusic();
    }
}

}
