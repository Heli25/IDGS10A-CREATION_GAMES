using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EternityFrame : MonoBehaviour
{
    private Frame frameInstance;
    private NayutaFrame nayutaframeInstance;
    private PowerFrame powerframeInstance;
    private DenjiFrame denjiframeInstance;
    public GameObject popupWindow2;

    void Start()
    {
        frameInstance = FindObjectOfType<Frame>();
        nayutaframeInstance = FindObjectOfType<NayutaFrame>();
        powerframeInstance = FindObjectOfType<PowerFrame>();
        denjiframeInstance = FindObjectOfType<DenjiFrame>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            frameInstance.OnButtonClick();
            nayutaframeInstance.OnButtonClick3();
            powerframeInstance.OnButtonClick4();
            denjiframeInstance.OnButtonClick5();
        }
    }

    public void OnButtonClick2()
    {
        // Habilita el objeto de la segunda ventana emergente para que se muestre
        popupWindow2.SetActive(true);
        // Deshabilita el objeto de la primera ventana emergente para que se oculte
        frameInstance.popupWindow.SetActive(false);
        nayutaframeInstance.popupWindow3.SetActive(false);
        powerframeInstance.popupWindow4.SetActive(false);
        denjiframeInstance.popupWindow5.SetActive(false);
    }
}
