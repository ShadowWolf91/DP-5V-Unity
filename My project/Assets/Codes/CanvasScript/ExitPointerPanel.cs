using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExitPointerPanel : MonoBehaviour, IPointerExitHandler
{
    // Start is called before the first frame update
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
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerExit(PointerEventData eventData)     // ������ ������ � ������
    {
        if (dropdownList != null)
        {
            dropdownTransfrom.sizeDelta = new Vector2(0, 0);
            triggerTransfrom.sizeDelta = buttonSize;    		// ������� ������� ��������������
            button.GetComponent<Image>().sprite = buttonNormalState; // ������� ����� ������
            dropdownList.SetActive(false); 				// ������������ ������ ����	
        }
    }
}
