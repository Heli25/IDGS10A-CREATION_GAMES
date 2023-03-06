using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball4 : MonoBehaviour
{
    private Ball2 ball2Instance;
    private Ball3 ball3Instance;
    private Ball1 ball1Instance;
    private Ball5 ball5Instance;
    private Ball6 ball6Instance;
    private Ball7 ball7Instance;
    private Ball8 ball8Instance;
    private Ball9 ball9Instance;
    private Ball10 ball10Instance;
    private Ball11 ball11Instance;
    private Ball12 ball12Instance;
    private Ball13 ball13Instance;
    private Ball14 ball14Instance;
    private Ball15 ball15Instance;
    public GameObject popupWindow4;

    void Start()
    {
        ball2Instance = FindObjectOfType<Ball2>();
        ball3Instance = FindObjectOfType<Ball3>();
        ball1Instance = FindObjectOfType<Ball1>();
        ball5Instance = FindObjectOfType<Ball5>();
        ball6Instance = FindObjectOfType<Ball6>();
        ball7Instance = FindObjectOfType<Ball7>();
        ball8Instance = FindObjectOfType<Ball8>();
        ball9Instance = FindObjectOfType<Ball9>();
        ball10Instance = FindObjectOfType<Ball10>();
        ball11Instance = FindObjectOfType<Ball11>();
        ball12Instance = FindObjectOfType<Ball12>();
        ball13Instance = FindObjectOfType<Ball13>();
        ball14Instance = FindObjectOfType<Ball14>();
        ball15Instance = FindObjectOfType<Ball15>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ball2Instance.OnButtonClick2();
            ball3Instance.OnButtonClick3();
            ball1Instance.OnButtonClick1();
            ball5Instance.OnButtonClick5();
            ball6Instance.OnButtonClick6();
            ball7Instance.OnButtonClick7();
            ball8Instance.OnButtonClick8();
            ball9Instance.OnButtonClick9();
            ball10Instance.OnButtonClick10();
            ball11Instance.OnButtonClick11();
            ball12Instance.OnButtonClick12();
            ball13Instance.OnButtonClick13();
            ball14Instance.OnButtonClick14();
            ball15Instance.OnButtonClick15();
        }
    }

    public void OnButtonClick4()
    {
        // Habilita el objeto de la ventana emergente para que se muestre
        popupWindow4.SetActive(true);
        ball2Instance.popupWindow2.SetActive(false);
        ball3Instance.popupWindow3.SetActive(false);
        ball1Instance.popupWindow1.SetActive(false);
        ball5Instance.popupWindow5.SetActive(false);
        ball6Instance.popupWindow6.SetActive(false);
        ball7Instance.popupWindow7.SetActive(false);
        ball8Instance.popupWindow8.SetActive(false);
        ball9Instance.popupWindow9.SetActive(false);
        ball10Instance.popupWindow10.SetActive(false);
        ball11Instance.popupWindow11.SetActive(false);
        ball12Instance.popupWindow12.SetActive(false);
        ball13Instance.popupWindow13.SetActive(false);
        ball14Instance.popupWindow14.SetActive(false);
        ball15Instance.popupWindow15.SetActive(false);
    }
}
