using TMPro;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    [SerializeField] private int max = 1000;
    [SerializeField] private int min;
    [SerializeField] private TextMeshProUGUI displayText;

    private int _guess;
    private int _guessCount;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        StartGame();
    }

    private void Update()
    {
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
            displayText.text += $"\nУра! Твое число угадано и равно {_guess}!";
            displayText.text += $"\nКоличество затраченных ходов: {_guessCount}";
            displayText.text += "\n";
            RestartGame();
        }
    }

    #endregion

    #region Private methods

    private void CalculateGuessAndLog()
    {
        _guess = (max + min) / 2;
        _guessCount++;
        displayText.text += $"\nТвое число равно {_guess}?";
    }

    private void RestartGame()
    {
        min = 0;
        max = 1000;
        _guessCount = 0;
        displayText.text += $"\nЗагадай число от {min} до {max}";

        CalculateGuessAndLog();
    }

    private void StartGame()
    {
        min = 0;
        max = 1000;
        _guessCount = 0;
        displayText.text = $"Загадай число от {min} до {max}";

        CalculateGuessAndLog();
    }

    #endregion
}