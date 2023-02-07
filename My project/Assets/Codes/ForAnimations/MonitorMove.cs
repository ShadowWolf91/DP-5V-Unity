using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MonitorMove : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public int rotation = 0;
    private Ray ray;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (rotation)
        {
            case 0:
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "MonitorRotation" && rotation >= 0 && rotation < 2)
                        {
                            anim.SetInteger("monRot", 1);
                            rotation = 1;
                        }
                    }
                }
                break;
            case 1:
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "MonitorRotation" && rotation >= 0 && rotation < 2)
                        {
                            anim.SetInteger("monRot", 2);
                            rotation += 1;
                        }
                    }
                }
                if (Input.GetMouseButtonDown(1))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "MonitorRotation" && rotation > 0 && rotation <= 2)
                        {
                            anim.SetInteger("monRot", 0);
                            rotation -= 1;
                        }
                    }
                }
                break;
            case 2:
                if (Input.GetMouseButtonDown(1))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "MonitorRotation" && rotation > 0 && rotation <= 2)
                        {
                            anim.SetInteger("monRot", 1);
                            rotation -= 1;
                        }
                    }
                }
                break;
        }
    }
}
