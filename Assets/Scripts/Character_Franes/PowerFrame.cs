using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerFrame : MonoBehaviour
{
    private Frame frameInstance;
    private EternityFrame eternityframeInstance;
    private NayutaFrame nayutaframeInstance;
    private DenjiFrame denjiframeInstance;
    public GameObject popupWindow4;

    void Start()
    {
        frameInstance = FindObjectOfType<Frame>();
        eternityframeInstance = FindObjectOfType<EternityFrame>();
        nayutaframeInstance = FindObjectOfType<NayutaFrame>();
        denjiframeInstance = FindObjectOfType<DenjiFrame>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            frameInstance.OnButtonClick();
            eternityframeInstance.OnButtonClick2();
            nayutaframeInstance.OnButtonClick3();
            denjiframeInstance.OnButtonClick5();
        }
    }

    public void OnButtonClick4()
    {
        // Habilita el objeto de la ventana emergente para que se muestre
        popupWindow4.SetActive(true);
        frameInstance.popupWindow.SetActive(false);
        eternityframeInstance.popupWindow2.SetActive(false);
        nayutaframeInstance.popupWindow3.SetActive(false);
        denjiframeInstance.popupWindow5.SetActive(false);
    }

}
