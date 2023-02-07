using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputForTable : MonoBehaviour
{
    // Start is called before the first frame update
    private Text message;  // объявить переменную и связать ее с объектом на сцене 
    void Start()
    {
        message = GameObject.FindGameObjectWithTag("M").GetComponent<Text>();
        Close();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Open()
    {
        gameObject.SetActive(true); //   АКТИВИРОВАТЬ ОБЪЕКТ, ЧТОБЫ ОТКРЫТЬ ОКНО.  
    }

    public void Close()
    {
        gameObject.SetActive(false); // ДЕАКТИВИРОВАТЬ ОБЪЕКТ, ЧТОБЫ ЗАКРЫТЬ ОКНО.  
    }
    public void Begining()
    {
        Open();  //  ОТКРЫТЬ ВСПЛЫВАЮЩЕЕ ТЕКСТОВОЕ ОКНО 
    }
    public void OnExit()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "";
        Close();
    }
    public void Task1()
    {
        message.text = "Задание 1. Проверить наличие и правильность расположения батареек в ДП-5В";
    }
    public void Task2()
    {
        message.text = "Задание 2. Надеваем головные телефоны";
    }
    public void Task3()
    {
        message.text = "Задание 3. Проверяем корректность работы ДП-5В включив подсветку и в режиме 'K' блока детектирования переключаем все поддиапозоны";
    }
    public void Task4()
    {
        message.text = "Задание 4. Надеваем на штатив блок детектирования";
    }
    public void Task5()
    {
        message.text = "Задание 5. Переключаем в блоке детектирования на режим 'Г' прокручиванием экрана, в переключателе поддиапозонов установите на '200'";
    }
    public void Task6()
    {
        message.text = "Задание 6. Подносим блок детектирования к объекту с гаммо-излучением";
    }
    public void Task7()
    {
        message.text = "Задание 7. Смотрим на микроамперметр и на сколько откланилась стрелка и записываем данные";
    }
    public void Task8()
    {
        message.text = "Задание 8. Переключаем в блоке детектирования на режим 'Б' прокручиванием экрана";
    }
    public void Task9()
    {
        message.text = "Задание 9. Подносим блок детектирования к объекту с бета-излучением";
    }
    public void Task10()
    {
        message.text = "Задание 10. Смотрим на микроамперметр и на сколько откланилась стрелка и записываем данные";
    }
    public void Task11()
    {
        message.text = "Задание 11. Переключаем в блоке детектирования на режим 'Г' прокручиванием экрана, в переключателе поддиапозонов установите на 'x1000'";
    }
    public void Task12()
    {
        message.text = "Задание 12. Повторяем все дествия с 5 пункта проходя 2 режима измерения излучений и все поддиапозоны, занося их в таблицу";
    }
    public void Task13()
    {
        message.text = "Задание 13. После выполнения всех поддиапозонов в 2 режимах измерения излучения и с данными в таблице, разбираем штатив с блоком детектирования, снимаем наушники и все ложим на место.";
    }
}
