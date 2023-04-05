using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EternityFrame : MonoBehaviour
{

    public Image Imagen;
    public GameObject popupWindow2;
    public TextMeshProUGUI text;

    private AkiFrame akiframeInstance;
    private NayutaFrame nayutaframeInstance;
    private PowerFrame powerframeInstance;
    private DenjiFrame denjiframeInstance;

    public string TextChange = "Normal Demon";

    void Start()
    {
        Imagen = GameObject.Find("PlayerSpawner").GetComponent<Image>();
        text = GameObject.Find("TextSpawner").GetComponent<TextMeshProUGUI>();

        akiframeInstance = FindObjectOfType<AkiFrame>();
        nayutaframeInstance = FindObjectOfType<NayutaFrame>();
        powerframeInstance = FindObjectOfType<PowerFrame>();
        denjiframeInstance = FindObjectOfType<DenjiFrame>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            akiframeInstance.OnButtonClick();
            nayutaframeInstance.OnButtonClick3();
            powerframeInstance.OnButtonClick4();
            denjiframeInstance.OnButtonClick5();
        }
    }

    public void OnButtonClick2()
    {
        popupWindow2.SetActive(true);
        akiframeInstance.popupWindow.SetActive(false);
        nayutaframeInstance.popupWindow3.SetActive(false);
        powerframeInstance.popupWindow4.SetActive(false);
        denjiframeInstance.popupWindow5.SetActive(false);

        Imagen.sprite = Resources.Load<Sprite>("Personajes/eternidad");
        text.text = TextChange;

    }

}
