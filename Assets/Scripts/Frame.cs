using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame : MonoBehaviour
{
    private EternityFrame eternityframeInstance;
    private NayutaFrame nayutaframeInstance;
    private PowerFrame powerframeInstance;
    private DenjiFrame denjiframeInstance;
    public GameObject popupWindow;

    void Start()
    {
        eternityframeInstance = FindObjectOfType<EternityFrame>();
        nayutaframeInstance = FindObjectOfType<NayutaFrame>();
        powerframeInstance = FindObjectOfType<PowerFrame>();
        denjiframeInstance = FindObjectOfType<DenjiFrame>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            eternityframeInstance.OnButtonClick2();
            nayutaframeInstance.OnButtonClick3();
            powerframeInstance.OnButtonClick4();
            denjiframeInstance.OnButtonClick5();
        }
    }

    public void OnButtonClick()
    {
        // Habilita el objeto de la ventana emergente para que se muestre
        popupWindow.SetActive(true);
        eternityframeInstance.popupWindow2.SetActive(false);
        nayutaframeInstance.popupWindow3.SetActive(false);
        powerframeInstance.popupWindow4.SetActive(false);
        denjiframeInstance.popupWindow5.SetActive(false);
    }
}



