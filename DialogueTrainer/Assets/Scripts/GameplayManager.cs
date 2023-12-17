using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    #region Instance
    public static GameplayManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public void TextContainerNextButtonPressed()
    {
        ShowScenario();
    }
    void ShowScenario()
    {
        GameplayUI.Instance.TextContainer.SetActive(false);
        GameplayUI.Instance.Scenario1.SetActive(true);

        AudioManager.Instance.PlaySound(AudioManager.Instance.Scenario1);
    }

    public void Scenario1NextButtonPressed()
    {
        GameplayUI.Instance.Scenario1.SetActive(false);
        AudioManager.Instance.StopSound();

        Scenario1Question1();
    }

    void Scenario1Question1()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question1Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q1Tayla);
    }
    public void ShowScenario1Question1AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question1Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer1Box.SetActive(true);
    }
    public void Scenario1Answer1Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A1APlayer);
                GameplayUI.Instance.Scenario1Answer1Selected(answerNumber);

                break;
            case 2:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A1BPlayer);
                GameplayUI.Instance.Scenario1Answer1Selected(answerNumber);
                break;
            case 3:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A1CPlayer);
                GameplayUI.Instance.Scenario1Answer1Selected(answerNumber);
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
}