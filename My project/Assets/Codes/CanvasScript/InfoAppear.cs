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
        gameObject.SetActive(true); //   ������������ ������, ����� ������� ����.  
    }

    public void Close()
    {
        gameObject.SetActive(false); // �������������� ������, ����� ������� ����.  
    }

    public void OnExit()
    {   //  �����, ���������� ������������� ������� �� ������ 
        text.text = "";
        Close();
    }


    public void OnSettings()
    {  //  �����, ���������� ������������� ��� ����� ������� ���� � ������
        Open();  //  ������� ����������� ��������� ���� 
        text.text = "��������� ������������ ��� ���������� ������������� ���������� � ����������� ������ � ����������, �������������� �� ������ ����������." +
            "����� ���� ��-5�, ��������, ��� ��������� �������� � �������, ����������� ��� ���������.";
    }
    public void OnPointerEnterMeasuringCoonsole()
    {
        Open();
        text.text = "������������� �����";
    }
    public void OnPointerEnterDetectBlock()
    {
        Open();
        text.text = "���� ��������������";
    }
    public void OnPointerEnterHeadphones()
    {
        Open();
        text.text = "�������� ��������";
    }
    public void OnPointerEnterTripod()
    {
        Open();
        text.text = "������";
    }
    public void OnPointerEnterBattaries()
    {
        Open();
        text.text = "���������";
    }
}