using UnityEngine;

public class Step : MonoBehaviour
{
    #region Variables

    [TextArea(5, 10)]
    [SerializeField] private string _answers;
    [TextArea(3, 10)]
    [SerializeField] private string _description;
    [SerializeField] private Step[] _nextSteps;

    #endregion

    #region Properties

    public string Answers => _answers;
    public string Description => _description; //returns значение
    public Step[] NextSteps => _nextSteps;

    #endregion

    // [SerializeField] private Step _nextStep2;
    // public Step NextStep => _nextStep;
    // public Step NextStep2 => _nextStep2;
}