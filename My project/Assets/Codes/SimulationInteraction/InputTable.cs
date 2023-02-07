using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTable : MonoBehaviour
{
    [SerializeField]
    InputField textInput;

    [SerializeField]
    Text dg1;
    [SerializeField]
    Text dg2;
    [SerializeField]
    Text dg3;
    [SerializeField]
    Text dg4;
    [SerializeField]
    Text dg5;
    [SerializeField]
    Text dg6;
    [SerializeField]
    Text db1;
    [SerializeField]
    Text db2;
    [SerializeField]
    Text db3;
    [SerializeField]
    Text db4;
    [SerializeField]
    Text db5;
    [SerializeField]
    Text db6;
    [SerializeField]
    Text safety1;
    [SerializeField]
    Text safety2;
    [SerializeField]
    Text safety3;
    [SerializeField]
    Text safety4;
    [SerializeField]
    Text safety5;
    [SerializeField]
    Text safety6;
    //функция для кнопки «Записать»
    public void WriteValue()
    {
        if (dg1.text == "-")
            dg1.text = textInput.text.ToString();
        else if (db1.text == "-")
        {
            db1.text = textInput.text.ToString();
            if (int.Parse(dg1.text) + int.Parse(db1.text) > 1)
            {
                safety1.text = "Небезопасно";
            }
            else { safety1.text = "Безопасно"; }
            //dg3.text = (int.Parse(dg1.text) * int.Parse(db1.text)).ToString();
        }
        else if (dg2.text == "-")
            dg2.text = textInput.text.ToString();
        else if (db2.text == "-")
        {
            db2.text = textInput.text.ToString();
            if (int.Parse(dg2.text) + int.Parse(db2.text) > 1)
            {
                safety2.text = "Небезопасно";
            }
            else { safety2.text = "Безопасно"; }
        }
        else if (dg3.text == "-")
            dg3.text = textInput.text.ToString();
        else if (db3.text == "-")
        {
            dg3.text = textInput.text.ToString();
            if (int.Parse(dg3.text) + int.Parse(db3.text) > 1)
            {
                safety3.text = "Небезопасно";
            }
            else { safety3.text = "Безопасно"; }
        }
        else if (dg4.text == "-")
            dg4.text = textInput.text.ToString();
        else if (db4.text == "-")
        {
            db4.text = textInput.text.ToString();
            if (int.Parse(dg4.text) + int.Parse(db4.text) > 1)
            {
                safety4.text = "Небезопасно";
            }
            else { safety4.text = "Безопасно"; }
        }
        else if (dg5.text == "-")
            dg5.text = textInput.text.ToString();
        else if (db5.text == "-")
        {
            db5.text = textInput.text.ToString();
            if (int.Parse(dg5.text) + int.Parse(db5.text) > 1)
            {
                safety5.text = "Небезопасно";
            }
            else { safety5.text = "Безопасно"; }
        }
        else if (dg6.text == "-")
            dg6.text = textInput.text.ToString();
        else if (db6.text == "-")
        {
            db6.text = textInput.text.ToString();
            if (int.Parse(dg6.text) + int.Parse(db6.text) > 1)
            {
                safety6.text = "Небезопасно";
            }
            else { safety6.text = "Безопасно"; }
        }
        textInput.text = "";
    }
    //функция для кнопки «Очистить»
    public void Clean()
    {
        dg1.text = "-";
        dg2.text = "-";
        dg3.text = "-";
        dg4.text = "-";
        dg5.text = "-";
        dg6.text = "-";
        db1.text = "-";
        db2.text = "-";
        db3.text = "-";
        db4.text = "-";
        db5.text = "-";
        db6.text = "-";
        safety1.text = "-";
        safety2.text = "-";
        safety3.text = "-";
        safety4.text = "-";
        safety5.text = "-";
        safety6.text = "-";
    }
}