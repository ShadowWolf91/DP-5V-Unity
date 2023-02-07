using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputForTable : MonoBehaviour
{
    // Start is called before the first frame update
    private Text message;  // �������� ���������� � ������� �� � �������� �� ����� 
    void Start()
    {
        message = GameObject.FindGameObjectWithTag("M").GetComponent<Text>();
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
    public void Begining()
    {
        Open();  //  ������� ����������� ��������� ���� 
    }
    public void OnExit()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "";
        Close();
    }
    public void Task1()
    {
        message.text = "������� 1. ��������� ������� � ������������ ������������ �������� � ��-5�";
    }
    public void Task2()
    {
        message.text = "������� 2. �������� �������� ��������";
    }
    public void Task3()
    {
        message.text = "������� 3. ��������� ������������ ������ ��-5� ������� ��������� � � ������ 'K' ����� �������������� ����������� ��� ������������";
    }
    public void Task4()
    {
        message.text = "������� 4. �������� �� ������ ���� ��������������";
    }
    public void Task5()
    {
        message.text = "������� 5. ����������� � ����� �������������� �� ����� '�' �������������� ������, � ������������� ������������� ���������� �� '200'";
    }
    public void Task6()
    {
        message.text = "������� 6. �������� ���� �������������� � ������� � �����-����������";
    }
    public void Task7()
    {
        message.text = "������� 7. ������� �� �������������� � �� ������� ����������� ������� � ���������� ������";
    }
    public void Task8()
    {
        message.text = "������� 8. ����������� � ����� �������������� �� ����� '�' �������������� ������";
    }
    public void Task9()
    {
        message.text = "������� 9. �������� ���� �������������� � ������� � ����-����������";
    }
    public void Task10()
    {
        message.text = "������� 10. ������� �� �������������� � �� ������� ����������� ������� � ���������� ������";
    }
    public void Task11()
    {
        message.text = "������� 11. ����������� � ����� �������������� �� ����� '�' �������������� ������, � ������������� ������������� ���������� �� 'x1000'";
    }
    public void Task12()
    {
        message.text = "������� 12. ��������� ��� ������� � 5 ������ ������� 2 ������ ��������� ��������� � ��� ������������, ������ �� � �������";
    }
    public void Task13()
    {
        message.text = "������� 13. ����� ���������� ���� ������������� � 2 ������� ��������� ��������� � � ������� � �������, ��������� ������ � ������ ��������������, ������� �������� � ��� ����� �� �����.";
    }
}
