using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonDropdown : MonoBehaviour, IPointerEnterHandler
{

    public GameObject panelTrigger;		// ����� ������� ���������� � ��������
    RectTransform triggerTransfrom;		// ���������� ���� �������������� 
    public Button button;			// ������ ������
    RectTransform buttonTransfrom;		// ������������� ��� ������
    Vector2 buttonSize;			// ��������� ������ ��� ���������� ������
    public GameObject dropdownList;	// ������ ������ ����
    RectTransform dropdownTransfrom;        // ������������� ��� ������ ����
    Vector2 dropdownSize;   			 // ��������� ������ ��� ������ ����
    public Sprite buttonNormalState; 	//  ��� ������������ ��������� �������� �� ������
    public Sprite buttonHighlightedState;   //  ��� ������������ �������� �������� �� ������

    void Start()					// ������������� � ������� �������� ���������� 
    {
        if (dropdownList != null)
        {
            triggerTransfrom = panelTrigger.GetComponent<RectTransform>();
            buttonTransfrom = button.GetComponent<RectTransform>();
            dropdownTransfrom = dropdownList.GetComponent<RectTransform>();
            buttonSize = buttonTransfrom.sizeDelta;
            dropdownSize = dropdownTransfrom.sizeDelta; // ������ �������������� ������ ����
            dropdownTransfrom.sizeDelta = new Vector2(0, 0);
            triggerTransfrom.sizeDelta = buttonSize;             // ������ �������������� ������
            dropdownList.SetActive(false);		        // ����������� ����������� ������ ����
        }
    }

    public void OnPointerEnter(PointerEventData eventData)   // ��������� ������ �� ������
    {

        button.GetComponent<Image>().sprite = buttonHighlightedState;
        dropdownTransfrom.sizeDelta = dropdownSize;
        triggerTransfrom.sizeDelta = buttonSize + dropdownSize;     // ����� ������ ��������������
        dropdownList.SetActive(true);					// ��������� ������ ����	
    }
}