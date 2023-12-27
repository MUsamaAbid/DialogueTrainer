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

    //public GameObject TaylaCam;
    //public GameObject PlayerCam;

    public GameObject Tayla;
    public GameObject Player;

    [SerializeField] int NumberOfQuestions;

    public int[] Scenario1CorrectAnswers;
    int currentQuestion = 0;
    int currentAnswer;
    bool optionSelected = false;

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

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    void Scenario1Question2()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question2Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q2Tayla);

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    void Scenario1Question3()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question3Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q3Tayla);

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    void Scenario1Question4()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question4Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q4Tayla);

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    void Scenario1Question5()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question5Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q5Tayla);

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    void Scenario1Question6()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question6Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q6Tayla);

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    void Scenario1Question7()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question7Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q7Tayla);

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    void Scenario1Question8()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question8Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q8Tayla);

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    void Scenario1Question9()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question9Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q9Tayla);

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetTrigger("Talk");
    }
    public void ShowScenario1Question1AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question1Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer1Box.SetActive(true);

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);

    }
    public void ShowScenario1Question2AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question2Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer2Box.SetActive(true);

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);

    }
    public void ShowScenario1Question3AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question3Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer3Box.SetActive(true);

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);

    }
    public void ShowScenario1Question4AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question4Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer4Box.SetActive(true);

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void ShowScenario1Question5AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question5Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer5Box.SetActive(true);

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void ShowScenario1Question6AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question6Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer6Box.SetActive(true);

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void ShowScenario1Question7AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question7Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer7Box.SetActive(true);

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void ShowScenario1Question8AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question8Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer8Box.SetActive(true);

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void ShowScenario1Question9AnswerBox()
    {
        AudioManager.Instance.StopSound();

        GameplayUI.Instance.Scenario1Question9Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer9Box.SetActive(true);

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void Scenario1Answer1Selected(int answerNumber)
    {
        if (optionSelected) return;

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
        if (optionSelected) return;
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
    public void Scenario1Answer3Selected(int answerNumber)
    {
        if (optionSelected) return;
        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A3APlayer);
                GameplayUI.Instance.Scenario1Answer3Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 2:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A3BPlayer);
                GameplayUI.Instance.Scenario1Answer3Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 3:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A3CPlayer);
                GameplayUI.Instance.Scenario1Answer3Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
        currentAnswer = answerNumber;
    }
    public void Scenario1Answer4Selected(int answerNumber)
    {
        if (optionSelected) return;
        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A4APlayer);
                GameplayUI.Instance.Scenario1Answer4Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 2:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A4BPlayer);
                GameplayUI.Instance.Scenario1Answer4Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 3:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A4CPlayer);
                GameplayUI.Instance.Scenario1Answer4Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
        currentAnswer = answerNumber;
    }
    public void Scenario1Answer5Selected(int answerNumber)
    {
        if (optionSelected) return;
        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A5APlayer);
                GameplayUI.Instance.Scenario1Answer5Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 2:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A5BPlayer);
                GameplayUI.Instance.Scenario1Answer5Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 3:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A5CPlayer);
                GameplayUI.Instance.Scenario1Answer5Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
        currentAnswer = answerNumber;
    }
    public void Scenario1Answer6Selected(int answerNumber)
    {
        if (optionSelected) return;
        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A6APlayer);
                GameplayUI.Instance.Scenario1Answer6Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 2:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A6BPlayer);
                GameplayUI.Instance.Scenario1Answer6Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 3:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A6CPlayer);
                GameplayUI.Instance.Scenario1Answer6Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
        currentAnswer = answerNumber;
    }
    public void Scenario1Answer7Selected(int answerNumber)
    {
        if (optionSelected) return;
        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A7APlayer);
                GameplayUI.Instance.Scenario1Answer7Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 2:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A7BPlayer);
                GameplayUI.Instance.Scenario1Answer7Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 3:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A7CPlayer);
                GameplayUI.Instance.Scenario1Answer7Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
        currentAnswer = answerNumber;
    }
    public void Scenario1Answer8Selected(int answerNumber)
    {
        if (optionSelected) return;
        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A8APlayer);
                GameplayUI.Instance.Scenario1Answer8Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 2:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A8BPlayer);
                GameplayUI.Instance.Scenario1Answer8Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 3:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A8CPlayer);
                GameplayUI.Instance.Scenario1Answer8Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
        currentAnswer = answerNumber;
    }
    public void Scenario1Answer9Selected(int answerNumber)
    {
        if (optionSelected) return;
        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A9APlayer);
                GameplayUI.Instance.Scenario1Answer9Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 2:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A9BPlayer);
                GameplayUI.Instance.Scenario1Answer9Selected(answerNumber);
                Player.GetComponent<Animator>().SetTrigger("Talk");
                break;

            case 3:
                AudioManager.Instance.StopSound();
                AudioManager.Instance.PlaySound(AudioManager.Instance.S1A9CPlayer);
                GameplayUI.Instance.Scenario1Answer9Selected(answerNumber);
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
        //GameplayUI.Instance.TurnQuestion1UIOff();
        //GameplayUI.Instance.TurnQuestion2UIOff();
        //GameplayUI.Instance.TurnQuestion3UIOff();
        //GameplayUI.Instance.TurnQuestion4UIOff();
        //GameplayUI.Instance.TurnQuestion5UIOff();
        //GameplayUI.Instance.TurnQuestion6UIOff();
        //GameplayUI.Instance.TurnQuestion7UIOff();
        //GameplayUI.Instance.TurnQuestion8UIOff();
        //GameplayUI.Instance.TurnQuestion9UIOff();
        optionSelected = true;
        AudioManager.Instance.StopSound();
        if (currentAnswer == Scenario1CorrectAnswers[currentQuestion])
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

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);
        currentQuestion++;
        Invoke("LoadNextQuestion", 3f);
    }
    void LoadNextQuestion()
    {
        GameplayUI.Instance.TurnQuestion1UIOff();
        GameplayUI.Instance.TurnQuestion2UIOff();
        GameplayUI.Instance.TurnQuestion3UIOff();
        GameplayUI.Instance.TurnQuestion4UIOff();
        GameplayUI.Instance.TurnQuestion5UIOff();
        GameplayUI.Instance.TurnQuestion6UIOff();
        GameplayUI.Instance.TurnQuestion7UIOff();
        GameplayUI.Instance.TurnQuestion8UIOff();
        GameplayUI.Instance.TurnQuestion9UIOff();

        optionSelected = false;

        if (currentQuestion <= NumberOfQuestions - 1)
        {
            switch (currentQuestion)
            {
                case 0:
                    Scenario1Question1();
                    break;
                case 1:
                    Scenario1Question2();
                    break;
                case 2:
                    Scenario1Question3();
                    break;
                case 3:
                    Scenario1Question4();
                    break;
                case 4:
                    Scenario1Question5();
                    break;
                case 5:
                    Scenario1Question6();
                    break;
                case 6:
                    Scenario1Question7();
                    break;
                case 7:
                    Scenario1Question8();
                    break;
                case 8:
                    Scenario1Question9();
                    break;
            }
        }
        else
        {
            Debug.Log("Game ended");
        }
    }
}