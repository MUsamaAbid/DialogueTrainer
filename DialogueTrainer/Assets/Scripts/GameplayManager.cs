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

    public GameObject TaylaCam;
    public GameObject PlayerCam;

    public GameObject Tayla;
    public GameObject Player;

    public int[] Scenario1CorrectAnswers;
    int currentQuestion = 0;
    int currentAnswer;

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

        TaylaCam.SetActive(true);
        PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    void Scenario1Question2()
    {
        GameplayUI.Instance.TurnQuestion1UIOff();

        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question2Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q2Tayla);

        TaylaCam.SetActive(true);
        PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    public void ShowScenario1Question1AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question1Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer1Box.SetActive(true);

        PlayerCam.SetActive(true);
        TaylaCam.SetActive(false);

    }
    public void ShowScenario1Question2AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question2Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer2Box.SetActive(true);

        PlayerCam.SetActive(true);
        TaylaCam.SetActive(false);

    }
    public void Scenario1Answer1Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A1APlayer);
                GameplayUI.Instance.Scenario1Answer1Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 2:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A1BPlayer);
                GameplayUI.Instance.Scenario1Answer1Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 3:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A1CPlayer);
                GameplayUI.Instance.Scenario1Answer1Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
        currentAnswer = answerNumber;
    }
    public void Scenario1Answer2Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A2APlayer);
                GameplayUI.Instance.Scenario1Answer2Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 2:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A2BPlayer);
                GameplayUI.Instance.Scenario1Answer2Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 3:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A2CPlayer);
                GameplayUI.Instance.Scenario1Answer2Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
        currentAnswer = answerNumber;
    }
    public void Scenario1CheckForAnswer()
    {
        AudioManager.Instance.StopSound();
        if(currentAnswer == Scenario1CorrectAnswers[currentQuestion])
        {
            Debug.Log("Correct Answer");
            Tayla.GetComponent<Animator>().SetTrigger("Happy");
            ScoreManager.Instance.AddScore(20);
        }
        else
        {
            Tayla.GetComponent<Animator>().SetTrigger("Sad");
            Debug.Log("false answer");
        }
        GameplayUI.Instance.AnswerNextButtonInteractables();

        TaylaCam.SetActive(true);
        PlayerCam.SetActive(false);
        currentQuestion++;
        Invoke("LoadNextQuestion",5f);
    }
    void LoadNextQuestion()
    {
        switch (currentQuestion)
        {
            case 0:
                Scenario1Question1();
                break;
            case 1:
                Scenario1Question2();
                break;
        }
    }
}