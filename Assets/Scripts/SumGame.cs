using TMPro;
using UnityEngine;

public class SumGame : MonoBehaviour
{
    #region Variables

    [SerializeField] private TextMeshProUGUI displayText;
    private int max;
    private int min;
    private int moveCount;
    private int sum = 0;
    private int targetSum = 50;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        StartGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddToSumAndLog(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AddToSumAndLog(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            AddToSumAndLog(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            AddToSumAndLog(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            AddToSumAndLog(5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            AddToSumAndLog(6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            AddToSumAndLog(7);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            AddToSumAndLog(8);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            AddToSumAndLog(9);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sum = 0;
            displayText.text += $"\nСумма равна: {sum}";
        }

        if (sum >= targetSum)
        {
            displayText.text += $"\nИгра окончена! \nКоличество затраченных ходов {moveCount}";
            RestartGame();
        }
            
    }

    #endregion

    #region Private methods

    private void AddToSumAndLog(int number)
    {
        sum += number;
        displayText.text += $"\nСумма равна: {sum}";
        moveCount++;
    }
    private void StartGame()
    {
        moveCount = 0;
        sum = 0;
        min = 1;
        max = 9;
        displayText.text = $"\nНажми цифру от {min} до {max}";
    }
    
    private void RestartGame()
    {
        moveCount = 0;
        sum = 0;
        min = 1;
        max = 9;
        displayText.text += $"\nНажми цифру от {min} до {max}";
    }

    #endregion
}