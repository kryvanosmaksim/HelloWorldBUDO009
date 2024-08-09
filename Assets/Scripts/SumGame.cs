using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class SumGame : MonoBehaviour
{
    #region Variables

    [SerializeField] private TextMeshProUGUI _displayText;
    private int _max;
    private int _min;
    private int _moveCount;
    private int _sum = 0;
    private int _targetSum = 50;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _displayText.text = "";
        StartGame();
    }

    private void Update()
    {
        HandleInput();
        CheckEndConditions();
    }

    private void CheckEndConditions()
    {
        if (_sum >= _targetSum)
        {
            _displayText.text += $"\nИгра окончена! \nКоличество затраченных ходов {_moveCount}";
            StartGame();
        }
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddToSumAndLog(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AddToSumAndLog(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            AddToSumAndLog(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            AddToSumAndLog(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            AddToSumAndLog(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            AddToSumAndLog(6);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            AddToSumAndLog(7);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            AddToSumAndLog(8);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            AddToSumAndLog(9);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            _sum = 0;
            _displayText.text += $"\nСумма равна: {_sum}";
        }
    }

    #endregion

    #region Private methods

    private void AddToSumAndLog(int number)
    {
        _sum += number;
        _displayText.text += $"\nСумма равна: {_sum}";
        _moveCount++;
    }
    private void StartGame()
    {
        _moveCount = 0;
        _sum = 0;
        _min = 1;
        _max = 9;
        _displayText.text += $"\nНажми цифру от {_min} до {_max}";
    }
    

    #endregion
}