using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    int move = 0;
    public Animator anima;
    GameObject rheadPhones;
    GameObject lheadPhones;
    AudioSource left;
    AudioSource right;
    private Ray ray;
    void Start()
    {
        //deviationArrow = GameObject.FindGameObjectWithTag("divArr");
        rheadPhones = GameObject.FindWithTag("rhp");
        lheadPhones = GameObject.FindWithTag("lhp");
        right = rheadPhones.GetComponent<AudioSource>();
        left = lheadPhones.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (move)
        {
            case 0:
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "Switcher" && move >= 0 && move < 7)
                        {
                            move += 1;
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
                        if (hit.collider.gameObject.name == "Switcher" && move >= 0 && move < 7)
                        {
                            move += 1;
                        }
                    }
                }
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "ButtonReset")
                        {
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
                        if (hit.collider.gameObject.name == "Switcher" && move >= 0 && move < 7)
                        {
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
                        if (hit.collider.gameObject.name == "Switcher" && move >= 0 && move < 7)
                        {
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
                        if (hit.collider.gameObject.name == "Switcher" && move >= 0 && move < 7)
                        {
                            move += 1;
                        }
                    }
                }
                if (Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject.name == "ButtonReset")
                        {
                            anima.SetInteger("runArr", 4);
                            left.Stop();
                            right.Stop();
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
                        if (hit.collider.gameObject.name == "Switcher" && move >= 0 && move < 7)
                        {
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
                            move -= 1;
                        }
                    }
                }
                break;

        }
    }
}