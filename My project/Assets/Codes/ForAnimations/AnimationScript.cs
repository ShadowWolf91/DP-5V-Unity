using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
//using static UnityEditor.FilePathAttribute;

public class AnimationScript : MonoBehaviour
{
    Animator anim;                //переменная типа Animator для ссылки на анимацию
    public GameObject lightObj;
    Light lightComp;
    private Ray ray;

    void Start()
    {
        anim = GetComponent<Animator>();   //контроллера анимации 
        lightObj = GameObject.FindGameObjectWithTag("BLight");
        lightComp = lightObj.GetComponent<Light>();
        lightComp.enabled = false;

    }
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))  //если нажата клавиша q
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "LightSwitcher" && lightComp.enabled == false)
                {
                    anim.SetBool("turn", true);  // переменная, отвечающая за переход имеет значение true
                    Thread.Sleep(350);
                    lightComp.enabled = true;
                }
            }

        }
        if(Input.GetMouseButtonDown(1))  //если нажата клавиша e отпускается
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "LightSwitcher" && lightComp.enabled == true)
                {
                    anim.SetBool("turn", false); // переменная, отвечающая за переход имеет значение false
                    Thread.Sleep(350);
                    lightComp.enabled = false;
                }
            }
        }
    }
}
