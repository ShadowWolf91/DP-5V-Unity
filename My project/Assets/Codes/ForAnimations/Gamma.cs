using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamma : MonoBehaviour
{
    GameObject GameObject;
    RangeSwitch rangeSwitch;
    GameObject game;
    MonitorMove monitorMove;
    public int rh;
    System.Random rnd = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        GameObject = GameObject.FindGameObjectWithTag("switcher");
        game = GameObject.FindGameObjectWithTag("monitor");
        rangeSwitch = GameObject.GetComponent<RangeSwitch>();
        monitorMove = game.GetComponent<MonitorMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rangeSwitch.move == 2 && monitorMove.rotation == 1)
        {
            rh = rnd.Next(5, 200) * 1000;
        }
        else if (rangeSwitch.move == 3 && monitorMove.rotation == 1)
        {
            rh = rnd.Next(500, 5000);
        }
        else if (rangeSwitch.move == 4 && monitorMove.rotation == 1)
        {
            rh = rnd.Next(50, 500);
        }
        else if (rangeSwitch.move == 5 && monitorMove.rotation == 1)
        {
            rh = rnd.Next(5, 50);
        }
        else if (rangeSwitch.move == 6 && monitorMove.rotation == 1)
        {
            rh = rnd.Next(5, 50) / 10;
        }
        else if (rangeSwitch.move == 7 && monitorMove.rotation == 1)
        {
            rh = rnd.Next(5, 50) / 100;
        }
        else 
        {
            rh = 0;
        }
    }
}
