using UnityEngine;
using UnityEngine.Serialization;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    private int _guess;
    [SerializeField] private int max; // best practice! to show up in inspector
    [SerializeField] private int min;

    #endregion

    #region Unity lifecycle

    private void Start() // вызывается постоянно
    {
        min = 0;
        max = 1000;
        Debug.Log($"Загадай число от {min} до {max}");

        CalculateGuessAndLog(); // Cmd + R + M (Extract Method) - вынести строки в новый метод 
    }

    private void Update() //вызывается каждый кадр
    {
        // bool isPressed = Input.GetKeyDown(KeyCode.DownArrow); //принимает нажатие кнопки
        // bool isPressed2 = Input.GetKeyUp(KeyCode.DownArrow); //принимает отпускание кнопки
        // bool isPressed3 = Input.GetKey(KeyCode.DownArrow); //принимает все время нажатия кнопки
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = _guess;
            CalculateGuessAndLog();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = _guess;
            CalculateGuessAndLog();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Ура! Твое число угадано и равно {_guess}!");
        }
    }

    #endregion
    
    private void CalculateGuessAndLog() // если есть копипаста, то лучше это вынести в отдельный метод
    {
        _guess = (max + min) / 2;
        Debug.Log($"Твое число равно {_guess} ?");
    }
}
