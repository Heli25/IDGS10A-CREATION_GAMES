using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NayutaFrame : MonoBehaviour
{
    public Image Imagen;
    public GameObject popupWindow3;
    private AkiFrame akiframeInstance;
    private EternityFrame eternityframeInstance;
    private PowerFrame powerframeInstance;
    private DenjiFrame denjiframeInstance;
    public TextMeshProUGUI text;

    public string TextChange = "Reincarnated Demon";
    
    void Start()
    {
        Imagen = GameObject.Find("PlayerSpawner").GetComponent<Image>();
        text = GameObject.Find("TextSpawner").GetComponent<TextMeshProUGUI>();

        akiframeInstance = FindObjectOfType<AkiFrame>();
        eternityframeInstance = FindObjectOfType<EternityFrame>();
        powerframeInstance = FindObjectOfType<PowerFrame>();
        denjiframeInstance = FindObjectOfType<DenjiFrame>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            akiframeInstance.OnButtonClick();
            eternityframeInstance.OnButtonClick2();
            powerframeInstance.OnButtonClick4();
            denjiframeInstance.OnButtonClick5();
        }
    }

    public void OnButtonClick3()
    {
        popupWindow3.SetActive(true);
        akiframeInstance.popupWindow.SetActive(false);
        eternityframeInstance.popupWindow2.SetActive(false);
        powerframeInstance.popupWindow4.SetActive(false);
        denjiframeInstance.popupWindow5.SetActive(false);
        Imagen.sprite = Resources.Load<Sprite>("Personajes/nayuta");
        text.text = TextChange;
    }

}

