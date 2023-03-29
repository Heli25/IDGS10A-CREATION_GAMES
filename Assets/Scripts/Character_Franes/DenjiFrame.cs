using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DenjiFrame : MonoBehaviour
{
    public Image Imagen;
    private AkiFrame akiframeInstance;
    private EternityFrame eternityframeInstance;
    private NayutaFrame nayutaframeInstance;
    private PowerFrame powerframeInstance;
    public GameObject popupWindow5;

    void Start()
    {
        Imagen = GameObject.Find("PlayerSpawner").GetComponent<Image>();

        akiframeInstance = FindObjectOfType<AkiFrame>();
        eternityframeInstance = FindObjectOfType<EternityFrame>();
        nayutaframeInstance = FindObjectOfType<NayutaFrame>();
        powerframeInstance = FindObjectOfType<PowerFrame>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            akiframeInstance.OnButtonClick();
            eternityframeInstance.OnButtonClick2();
            nayutaframeInstance.OnButtonClick3();
            powerframeInstance.OnButtonClick4();
        }
    }


    public void OnButtonClick5()
    {
        // Habilita el objeto de la segunda ventana emergente para que se muestre
        popupWindow5.SetActive(true);
        // Deshabilita el objeto de la primera ventana emergente para que se oculte
        akiframeInstance.popupWindow.SetActive(false);
        eternityframeInstance.popupWindow2.SetActive(false);
        nayutaframeInstance.popupWindow3.SetActive(false);
        powerframeInstance.popupWindow4.SetActive(false);

        Imagen.sprite = Resources.Load<Sprite>("Personajes/denji");
    }
}
