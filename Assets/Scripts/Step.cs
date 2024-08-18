using UnityEngine;
using UnityEngine.Serialization;

public class Step : MonoBehaviour
{
    #region Variables

    [TextArea(5, 10)]
    [SerializeField] private string _answers;
    [TextArea(3, 10)]
    [SerializeField] private string _description;
    [SerializeField] private string _locationName;
    [SerializeField] private Sprite _locationSprite;
    [SerializeField] private Step[] _nextSteps;

    #endregion

    #region Properties

    public string Answers => _answers;
    public string Description => _description;
    public string LocationName => _locationName;
    public Sprite LocationSprite => _locationSprite;
    public Step[] NextSteps => _nextSteps;

    #endregion
}