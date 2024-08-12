using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    #region Variables

    [SerializeField] private TMP_Text _descriptionLabel;
    [SerializeField] private TMP_Text _answerLabel;
    [SerializeField] private TMP_Text _locationLabel;
    [SerializeField] private Image _locationImage;
    [SerializeField] private Step _startStep;
    [SerializeField] private Step _currentStep;

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
        Texture2D texture = new(1, 1);
        texture.SetPixel(0, 0, new Color(0, 0, 0, 0));
        texture.Apply();
        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
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
    }

    private void UpdateUi()
    {
        _descriptionLabel.text = _currentStep.Description;
        _answerLabel.text = _currentStep.Answers;
        _locationLabel.text = _currentStep.LocationName;
        _locationImage.sprite = _currentStep.LocationImage ?? GetTransparentSprite();
    }

    #endregion

    // sfield - команда пишущая строку выше
}

// Debug.Log($"Description == null '{_descriptionLabel == null}'");
// _currentStep = _startStep;
// _descriptionLabel.text = _currentStep.Description;
// _answerLabel.text = _currentStep.Answers;