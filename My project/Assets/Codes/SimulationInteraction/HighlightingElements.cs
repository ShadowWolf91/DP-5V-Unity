using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HighlightingElements : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(0, 255, 255);
    }

    public void ChangeColorBack()
    {
        GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }
}
