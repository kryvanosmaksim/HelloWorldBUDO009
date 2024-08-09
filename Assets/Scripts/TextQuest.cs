using TMPro;
using UnityEngine;

public class TextQuest : MonoBehaviour
{
    #region Variables

    [SerializeField] private TMP_Text _descriptionLabel;
    [SerializeField] private TMP_Text _answerLabel;
    [SerializeField] private Step _startStep;
    [SerializeField] private Step _currentStep;
    // sfield - команда пишущая строку выше

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

    #endregion
}

// Debug.Log($"Description == null '{_descriptionLabel == null}'");
// _currentStep = _startStep;
// _descriptionLabel.text = _currentStep.Description;
// _answerLabel.text = _currentStep.Answers;