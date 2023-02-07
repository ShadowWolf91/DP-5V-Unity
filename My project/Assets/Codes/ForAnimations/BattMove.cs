using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattMove : MonoBehaviour
{
    Animator anim;                //переменная типа Animator для ссылки на анимацию
    private Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   //контроллера анимации 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "BatteryCorpus")
                {
                    anim.SetBool("bt", true);
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "BatteryCorpus")
                {
                    anim.SetBool("bt", false); // переменная, отвечающая за переход имеет значение false
                }
            }
        }
    }
}
