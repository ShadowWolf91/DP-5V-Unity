using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    Animator anim;                //переменная типа Animator для ссылки на анимацию
    public GameObject lightObj;
    Light lightComp;

    void Start()
    {
        anim = GetComponent<Animator>();   //контроллера анимации 
        lightObj = GameObject.FindGameObjectWithTag("BLight");
        lightComp = lightObj.GetComponent<Light>();
        lightComp.enabled = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))  //если нажата клавиша q
        {
            anim.SetBool("turn", true);  // переменная, отвечающая за переход имеет значение true
            Thread.Sleep(350);
            lightComp.enabled = true;

        }
        if(Input.GetKeyDown(KeyCode.E))  //если нажата клавиша e отпускается
        {
            anim.SetBool("turn", false); // переменная, отвечающая за переход имеет значение false
            Thread.Sleep(350);
            lightComp.enabled = false;

        }
    }
}
