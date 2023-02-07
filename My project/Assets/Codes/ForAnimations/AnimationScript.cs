using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    Animator anim;                //���������� ���� Animator ��� ������ �� ��������
    public GameObject lightObj;
    Light lightComp;

    void Start()
    {
        anim = GetComponent<Animator>();   //����������� �������� 
        lightObj = GameObject.FindGameObjectWithTag("BLight");
        lightComp = lightObj.GetComponent<Light>();
        lightComp.enabled = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))  //���� ������ ������� q
        {
            anim.SetBool("turn", true);  // ����������, ���������� �� ������� ����� �������� true
            Thread.Sleep(350);
            lightComp.enabled = true;

        }
        if(Input.GetKeyDown(KeyCode.E))  //���� ������ ������� e �����������
        {
            anim.SetBool("turn", false); // ����������, ���������� �� ������� ����� �������� false
            Thread.Sleep(350);
            lightComp.enabled = false;

        }
    }
}
