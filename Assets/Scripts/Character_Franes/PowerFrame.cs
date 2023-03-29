using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerFrame : MonoBehaviour
{
    public Image Imagen;
    private AkiFrame akiframeInstance;
    private EternityFrame eternityframeInstance;
    private NayutaFrame nayutaframeInstance;
    private DenjiFrame denjiframeInstance;
    public GameObject popupWindow4;

    void Start()
    {
        Imagen = GameObject.Find("PlayerSpawner").GetComponent<Image>();
        akiframeInstance = FindObjectOfType<AkiFrame>();
        eternityframeInstance = FindObjectOfType<EternityFrame>();
        nayutaframeInstance = FindObjectOfType<NayutaFrame>();
        denjiframeInstance = FindObjectOfType<DenjiFrame>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            akiframeInstance.OnButtonClick();
            eternityframeInstance.OnButtonClick2();
            nayutaframeInstance.OnButtonClick3();
            denjiframeInstance.OnButtonClick5();
        }
    }

    public void OnButtonClick4()
    {
        // Habilita el objeto de la ventana emergente para que se muestre
        popupWindow4.SetActive(true);
        akiframeInstance.popupWindow.SetActive(false);
        eternityframeInstance.popupWindow2.SetActive(false);
        nayutaframeInstance.popupWindow3.SetActive(false);
        denjiframeInstance.popupWindow5.SetActive(false);
        Imagen.sprite = Resources.Load<Sprite>("Personajes/power");
    }

}
