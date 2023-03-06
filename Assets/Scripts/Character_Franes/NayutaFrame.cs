using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NayutaFrame : MonoBehaviour
{
    public GameObject popupWindow3;
    private Frame frameInstance;
    private EternityFrame eternityframeInstance;
    private PowerFrame powerframeInstance;
    private DenjiFrame denjiframeInstance;
    
    void Start()
    {
        frameInstance = FindObjectOfType<Frame>();
        eternityframeInstance = FindObjectOfType<EternityFrame>();
        powerframeInstance = FindObjectOfType<PowerFrame>();
        denjiframeInstance = FindObjectOfType<DenjiFrame>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            frameInstance.OnButtonClick();
            eternityframeInstance.OnButtonClick2();
            powerframeInstance.OnButtonClick4();
            denjiframeInstance.OnButtonClick5();
        }
    }

    public void OnButtonClick3()
    {
        popupWindow3.SetActive(true);
        frameInstance.popupWindow.SetActive(false);
        eternityframeInstance.popupWindow2.SetActive(false);
        powerframeInstance.popupWindow4.SetActive(false);
        denjiframeInstance.popupWindow5.SetActive(false);
    }

}

