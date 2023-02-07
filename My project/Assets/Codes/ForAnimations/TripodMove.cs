using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripodMove : MonoBehaviour
{
    Animator anim;                //переменная типа Animator для ссылки на анимацию
    private Ray ray;
    public bool onBlock = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   //контроллера анимации 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
                    anim.SetBool("tm", true);
                    onBlock = true;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
                    anim.SetBool("tm", false);
                    onBlock = false;
        }
    }
}
