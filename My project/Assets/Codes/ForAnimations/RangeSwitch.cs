using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RangeSwitch : MonoBehaviour
{
    public int move = 0;
    Animator anim;
    public Animator anima;
    GameObject monitor;
    GameObject rheadPhones;
    GameObject lheadPhones;
    AudioSource left;
    AudioSource right;
    private Ray ray;
    MonitorMove monMove;
    // Start is called before the first frame update
    void Start()
    {
        //deviationArrow = GameObject.FindGameObjectWithTag("divArr");
        anim = GetComponent<Animator>();
        monitor = GameObject.FindWithTag("monitor");
        monMove = monitor.GetComponent<MonitorMove>();
        rheadPhones = GameObject.FindWithTag("rhp");
        lheadPhones = GameObject.FindWithTag("lhp");
        right = rheadPhones.GetComponent<AudioSource>();
        left = lheadPhones.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (move)
        { case 0:
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move >= 0 && move < 7)
                        {
                            anim.SetInteger("ranSwi", 1);
                            anima.SetInteger("runArr", 1);
                            move = 1;
                        }
                    }
                }
                //deviationArrow.transform.rotation = Quaternion.Euler(-56.408f, -90f, 90f);
                break;
            case 1:
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move >= 0 && move < 7)
                        {
                            anim.SetInteger("ranSwi", 2);
                            anima.SetInteger("runArr", 2);
                            //transform.Rotate(0f, 0f, 36f);
                            move += 1;
                        }
                    }
                }
                if (Input.GetMouseButtonDown(1))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move <= 7)
                        {
                            anim.SetInteger("ranSwi", 0);
                            anima.SetInteger("runArr", 0);
                            move -= 1;
                        }
                    }
                }
                break;
            case 2:
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move >= 0 && move < 7)
                        {
                            anim.SetInteger("ranSwi", 3);
                            if (monMove.rotation == 0)
                            {
                                anima.SetInteger("runArr", 3);
                            }
                            move += 1;
                        }
                    }
                }
                if (Input.GetMouseButtonDown(1))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move <= 7)
                        {
                            anim.SetInteger("ranSwi", 1);
                            anima.SetInteger("runArr", 1);
                            move -= 1;
                        }
                    }
                }
                break;
            case 3:
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move < 7)
                        {
                            anim.SetInteger("ranSwi", 4);
                            if (monMove.rotation == 0)
                            {
                                anima.SetInteger("runArr", 4);
                            }
                            move += 1;
                        }
                    }
                }
                if (Input.GetMouseButtonDown(1))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move <= 7)
                        {
                            anim.SetInteger("ranSwi", 2);
                            anima.SetInteger("runArr", 2);
                            move -= 1;
                        }
                    }
                }
                break;
            case 4:
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move < 7)
                        {
                            anim.SetInteger("ranSwi", 5);
                            if (monMove.rotation == 0)
                            {
                                anima.SetInteger("runArr", 5);
                                left.Play();
                                right.Play();
                            }
                            move += 1;
                        }
                    }
                }
                if (Input.GetMouseButtonDown(1))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move <= 7)
                        {
                            anim.SetInteger("ranSwi", 3);
                            if (monMove.rotation == 0)
                            {
                                anima.SetInteger("runArr", 3);
                            }
                            move -= 1;
                        }
                    }
                }
                break;
            case 5:
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move < 7)
                        {
                            anim.SetInteger("ranSwi", 6);
                            if (monMove.rotation == 0)
                            {
                                anima.SetInteger("runArr", 6);
                                left.Play();
                                right.Play();
                            }
                            move += 1;
                        }
                    }
                }
                if (Input.GetMouseButtonDown(1))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move <= 7)
                        {
                            anim.SetInteger("ranSwi", 4);
                            if (monMove.rotation == 0)
                            {
                                anima.SetInteger("runArr", 4);
                                left.Stop();
                                right.Stop();
                            }
                            move -= 1;
                        }
                    }
                }
                break;
            case 6:
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move < 7)
                        {
                            anim.SetInteger("ranSwi", 7);
                            if (monMove.rotation == 0)
                            {
                                anima.SetInteger("runArr", 7);
                                left.Play();
                                right.Play();
                            }
                            move += 1;
                        }
                    }
                }
                if (Input.GetMouseButtonDown(1))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move <= 7)
                        {
                            anim.SetInteger("ranSwi", 5);
                            if (monMove.rotation == 0)
                            {
                                anima.SetInteger("runArr", 5);
                                left.Play();
                                right.Play();
                            }
                            move -= 1;
                        }
                    }
                }
                break;
            case 7:
                if (Input.GetMouseButtonDown(1))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move <= 7)
                        {
                            anim.SetInteger("ranSwi", 6);
                            if (monMove.rotation == 0)
                            {
                                anima.SetInteger("runArr", 6);
                                left.Play();
                                right.Play();
                            }
                            move -= 1;
                        }
                    }
                }
                break;

        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray, out RaycastHit hit))
        //    {
        //        if (hit.collider.gameObject.name == "Switcher" && move >= 0 && move < 7)
        //        {

        //            //transform.Rotate(0f, 0f, 36f);
        //            move += 1;
        //        }
        //    }
        //}
        //if (Input.GetMouseButtonDown(1))
        //{
        //    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray, out RaycastHit hit))
        //    {
        //        if (hit.collider.gameObject.name == "Switcher" && move > 0 && move <= 7)
        //        {
        //            transform.Rotate(0f, 0f, -36f);
        //            move -= 1;
        //        }
        //    }
        //}
    }
}
