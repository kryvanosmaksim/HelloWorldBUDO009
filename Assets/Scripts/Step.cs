using UnityEngine;

public class Step : MonoBehaviour
{
    #region Variables

    [TextArea(5, 10)]
    [SerializeField] private string _answers;
    [TextArea(3, 10)]
    [SerializeField] private string _description;
    [SerializeField] private string _locationName;
    [SerializeField] private Sprite _locationImage;
    [SerializeField] private Step[] _nextSteps;

    #endregion

    #region Properties

    public string Answers => _answers;
    public string Description => _description;
    public string LocationName => _locationName;
    public Sprite LocationImage => _locationImage;
    public Step[] NextSteps => _nextSteps;

    #endregion
}