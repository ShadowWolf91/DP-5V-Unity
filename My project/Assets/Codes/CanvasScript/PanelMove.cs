using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelMove : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    RectTransform UIGameobject;                      // ������������� UI ������
    float width;                                                        // ������ ������
    float changeX;                                                   // �������� ������
    float speedPanel;                                             // �������� �������� ������

    enum states
    {                                             // ������������ ��������� ������
        open,                                                        //�������
        close,                                                        //�������
        opening,                                                  //�����������
        closing                                                     //�����������
    }
    states state = states.closing;                         // ����������� ��������� ��������

    void Start()
    {                                                  //������������� ����������
        UIGameobject = gameObject.GetComponent<RectTransform>();    // ������ ������
        width = 100;         // ����������� ������ ������
        speedPanel = 1;                                           // �������� �������� ������ 
    }

    void Update()
    {
        if (state == states.closing)
        {
            float x = UIGameobject.anchoredPosition.x;
            float y = UIGameobject.anchoredPosition.y;
            x += speedPanel;
            changeX += speedPanel;
            UIGameobject.anchoredPosition = new Vector2(x, y);
            if (changeX > width)
            {
                state = states.close;
                changeX = 0;
            }
        }
        if (state == states.opening)
        {
            float x = UIGameobject.anchoredPosition.x;
            float y = UIGameobject.anchoredPosition.y;
            x -= speedPanel;
            changeX += speedPanel;
            UIGameobject.anchoredPosition = new Vector2(x, y);
            if (changeX > width)
            {
                state = states.open;
                changeX = 0;
            }

        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (state == states.close) state = states.opening;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (state == states.open) state = states.closing;
    }
}