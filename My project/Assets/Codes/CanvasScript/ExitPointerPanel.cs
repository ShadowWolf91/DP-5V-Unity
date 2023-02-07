using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExitPointerPanel : MonoBehaviour, IPointerExitHandler
{
    // Start is called before the first frame update
    public GameObject panelTrigger;		// нужно связать переменную с объектом
    RectTransform triggerTransfrom;		// переменная типа прямоугольника 
    public Button button;			// объект кнопки
    RectTransform buttonTransfrom;		// прямоугольник для кнопки
    Vector2 buttonSize;			// двумерный вектор для размещения кнопки
    public GameObject dropdownList;	// объект списка меню
    RectTransform dropdownTransfrom;        // прямоугольник для списка меню
    Vector2 dropdownSize;   			 // двумерный вектор для списка меню
    public Sprite buttonNormalState; 	//  для накладывания начальной текстуры на кнопку
    public Sprite buttonHighlightedState;   //  для накладывания конечной текстуры на кнопку
    void Start()
    {
        if (dropdownList != null)
        {
            triggerTransfrom = panelTrigger.GetComponent<RectTransform>();
            buttonTransfrom = button.GetComponent<RectTransform>();
            dropdownTransfrom = dropdownList.GetComponent<RectTransform>();
            buttonSize = buttonTransfrom.sizeDelta;
            dropdownSize = dropdownTransfrom.sizeDelta; // размер прямоугольника списка меню
            dropdownTransfrom.sizeDelta = new Vector2(0, 0);
            triggerTransfrom.sizeDelta = buttonSize;             // размер прямоугольника кнопки
            dropdownList.SetActive(false);		        // активизация выпадающего списка меню
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerExit(PointerEventData eventData)     // убрали курсор с кнопки
    {
        if (dropdownList != null)
        {
            dropdownTransfrom.sizeDelta = new Vector2(0, 0);
            triggerTransfrom.sizeDelta = buttonSize;    		// возврат размера прямоугольника
            button.GetComponent<Image>().sprite = buttonNormalState; // возврат цвета кнопки
            dropdownList.SetActive(false); 				// дезактивация списка меню	
        }
    }
}
