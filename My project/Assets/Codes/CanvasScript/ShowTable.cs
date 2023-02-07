using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Open()
    {
        gameObject.SetActive(true); //   юйрхбхпнбюрэ назейр, врнаш нрйпшрэ нймн.  
    }

    public void Close()
    {
        gameObject.SetActive(false); // деюйрхбхпнбюрэ назейр, врнаш гюйпшрэ нймн.  
    }
    public void TableShow()
    {
        Open();
    }
    public void TableHide()
    {
        Close();
    }
}
