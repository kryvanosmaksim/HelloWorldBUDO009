using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    #region Variables

    [Header("UI Components")]
    [SerializeField] private TMP_Text _descriptionLabel;
    [SerializeField] private TMP_Text _answerLabel;
    [SerializeField] private TMP_Text _locationLabel;
    [SerializeField] private Image _locationSprite;
    
    [Header("Start Config")]
    [SerializeField] private Step _startStep;
    
    [Header("Debug")]
    [SerializeField] private Step _currentStep;
    private Sprite _transparentSprite;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        SetCurrentStepAndUpdateUi(_startStep);
    }

    private void Update()
    {
        ProcessInput();
    }

    #endregion

    #region Private methods

    private Sprite GetTransparentSprite()
    {
        Debug.LogError($"Get transparent sprite");
        if (_transparentSprite == null)
        {
            Debug.LogError($"Get transparent sprite CREATE NEW");
            Texture2D texture = new(1, 1);
            texture.SetPixel(0, 0, new Color(0, 0, 0, 0));
            texture.Apply();
            _transparentSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        }

        return _transparentSprite;
    }

    private void ProcessInput()
    {
        for (int i = 1; i <= 9; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                TryGoToNextStep(i);
            }
        }
    }

    private void SetCurrentStepAndUpdateUi(Step step)
    {
        _currentStep = step;

        UpdateUi();
    }

    private void TryGoToNextStep(int number)
    {
        int nextStepsIndex = number - 1; // number = 1, index = 0
        int nextStepsCount = _currentStep.NextSteps.Length;
        if (number > nextStepsCount)
        {
            return;
        }

        Step nextStep = _currentStep.NextSteps[nextStepsIndex];
        SetCurrentStepAndUpdateUi(nextStep);
        if (nextStep == null)
        {
            Debug.LogError($"For step '{_currentStep.name}' next step index '{nextStepsIndex}' is null!;");
        }
    }

    private void UpdateUi()
    {
        _descriptionLabel.text = _currentStep.Description;
        _answerLabel.text = _currentStep.Answers;
        _locationLabel.text = _currentStep.LocationName;
        
        Sprite sprite = _currentStep.LocationSprite;
        if(_currentStep.LocationSprite == null)
        {
            sprite = GetTransparentSprite();
        }

        _locationSprite.sprite = sprite;
    }

    #endregion

    // sfield - команда пишущая строку выше
}

// Debug.Log($"Description == null '{_descriptionLabel == null}'");
// _currentStep = _startStep;
// _descriptionLabel.text = _currentStep.Description;
// _answerLabel.text = _currentStep.Answers;