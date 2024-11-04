using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
//using static UnityEditor.FilePathAttribute;

public class AnimationScript : MonoBehaviour
{
    Animator anim;                //���������� ���� Animator ��� ������ �� ��������
    public GameObject lightObj;
    Light lightComp;
    private Ray ray;

    void Start()
    {
        anim = GetComponent<Animator>();   //����������� �������� 
        lightObj = GameObject.FindGameObjectWithTag("BLight");
        lightComp = lightObj.GetComponent<Light>();
        lightComp.enabled = false;

    }
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))  //���� ������ ������� q
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "LightSwitcher" && lightComp.enabled == false)
                {
                    anim.SetBool("turn", true);  // ����������, ���������� �� ������� ����� �������� true
                    Thread.Sleep(350);
                    lightComp.enabled = true;
                }
            }

        }
        if(Input.GetMouseButtonDown(1))  //���� ������ ������� e �����������
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "LightSwitcher" && lightComp.enabled == true)
                {
                    anim.SetBool("turn", false); // ����������, ���������� �� ������� ����� �������� false
                    Thread.Sleep(350);
                    lightComp.enabled = false;
                }
            }
        }
    }
}
