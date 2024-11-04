using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BettaAndGamma : MonoBehaviour
{
    GameObject GameObject;
    RangeSwitch rangeSwitch;
    GameObject game;
    MonitorMove monitorMove;
    GameObject arr;
    public Quaternion rh;
    //System.Random rnd = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        GameObject = GameObject.FindGameObjectWithTag("switcher");
        game = GameObject.FindGameObjectWithTag("monitor");
        arr = GameObject.FindGameObjectWithTag("divArr").GetComponent<GameObject>();
        rangeSwitch = GameObject.GetComponent<RangeSwitch>();
        monitorMove = game.GetComponent<MonitorMove>();
        rh = arr.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (rangeSwitch.move == 2 && monitorMove.rotation == 2)
        {
            rh = Quaternion.Euler(Random.Range(-47.0f, -122.0f), 0f, 0f);
            //rh = rnd.Next(1, 200)*1000;
        }
        else if (rangeSwitch.move == 3 && monitorMove.rotation == 2)
        {
            rh = Quaternion.Euler(Random.Range(-47.0f, -122.0f), 0f, 0f);
        }
        else if (rangeSwitch.move == 4 && monitorMove.rotation == 2)
        {
            rh = Quaternion.Euler(Random.Range(-47.0f, -122.0f), 0f, 0f);
        }
        else if (rangeSwitch.move == 5 && monitorMove.rotation == 2)
        {
            rh = Quaternion.Euler(Random.Range(-47.0f, -122.0f), 0f, 0f);
        }
        else if (rangeSwitch.move == 6 && monitorMove.rotation == 2)
        {
            rh = Quaternion.Euler(Random.Range(-47.0f, -122.0f), 0f, 0f);
        }
        else if (rangeSwitch.move == 7 && monitorMove.rotation == 2)
        {
            rh = Quaternion.Euler(Random.Range(-47.0f, -122.0f), 0f, 0f);
        }
        else
        {
            rh = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
