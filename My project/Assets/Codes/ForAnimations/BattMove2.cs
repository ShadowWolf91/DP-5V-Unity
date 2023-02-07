using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattMove2 : MonoBehaviour
{
    Animator anim;                //���������� ���� Animator ��� ������ �� ��������
    private Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   //����������� �������� 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "BatteryCorpus002")
                {
                    anim.SetBool("bt2", true);
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "BatteryCorpus002")
                {
                    anim.SetBool("bt2", false); // ����������, ���������� �� ������� ����� �������� false
                }
            }
        }
    }
}
