using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoAppear : MonoBehaviour
{
    private Text text;
   

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindGameObjectWithTag("T").GetComponent<Text>();
        Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        gameObject.SetActive(true); //   АКТИВИРОВАТЬ ОБЪЕКТ, ЧТОБЫ ОТКРЫТЬ ОКНО.   
    }

    public void Close()
    {
        gameObject.SetActive(false); // ДЕАКТИВИРОВАТЬ ОБЪЕКТ, ЧТОБЫ ЗАКРЫТЬ ОКНО.  
    }

    public void OnExit()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        text.text = "";
        Close();
    }


    public void OnSettings()
    {  //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ПРИ УХОДЕ КУРСОРА МЫШИ С КНОПКИ
        Open();  //  ОТКРЫТЬ ВСПЛЫВАЮЩЕЕ ТЕКСТОВОЕ ОКНО 
        text.text = "Симулятор предназначен для проведения лабораторного практикума в виртуальном режиме с установкой, представленной на экране компьютера." +
            "Перед нами ДП-5В, дозиметр, для измерения радиации в области, обнаруживая все излучения.";
    }
    public void OnPointerEnterMeasuringCoonsole()
    {
        Open();
        text.text = "Измерительный пульт";
    }
    public void OnPointerEnterDetectBlock()
    {
        Open();
        text.text = "Блок детектирования";
    }
    public void OnPointerEnterHeadphones()
    {
        Open();
        text.text = "Головные телефоны";
    }
    public void OnPointerEnterTripod()
    {
        Open();
        text.text = "Штатив";
    }
    public void OnPointerEnterBattaries()
    {
        Open();
        text.text = "Батарейки";
    }
}