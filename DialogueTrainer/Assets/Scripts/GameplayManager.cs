using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    Coroutine AudioCoroutine;

    [SerializeField] public int NumberOfQuestions;

    public int[] Scenario1CorrectAnswers;
    int currentQuestion = 0;
    int currentAnswer;
    bool optionSelected = false;

    bool isTalking;

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
    public void StartExtra()
    {
        GameplayUI.Instance.Scenario1.SetActive(false);
        GameplayUI.Instance.ExtraPanel.SetActive(true);

        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
        AudioManager.Instance.PlaySound(AudioManager.Instance.StartExtra);
    }
    public void StartExtraNextButton()
    {
        GameplayUI.Instance.ExtraPanel.SetActive(false);

        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        Scenario1Question1();
    }
    public void SecondExtra()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
        AudioManager.Instance.PlaySound(AudioManager.Instance.ExtraPanel2);
    }
    public void Scenario1NextButtonPressed()
    {
        GameplayUI.Instance.Scenario1.SetActive(false);
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        Scenario1Question1();
    }

    void Scenario1Question1()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question1Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q1Tayla);
        AudioCoroutine = StartCoroutine(StopAudio(AudioManager.Instance.S1Q1Tayla.length));

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetBool("Talk", true);
        BlendShape.Instance.Talking();
        isTalking = true;
    }
    void Scenario1Question2()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question2Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q2Tayla);
        AudioCoroutine = StartCoroutine(StopAudio(AudioManager.Instance.S1Q2Tayla.length));

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetBool("Talk", true); 
        BlendShape.Instance.Talking();
        isTalking = true;
    }
    void Scenario1Question3()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question3Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q3Tayla);
        AudioCoroutine = StartCoroutine(StopAudio(AudioManager.Instance.S1Q3Tayla.length));

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetBool("Talk", true); 
        BlendShape.Instance.Talking();
        isTalking = true;
    }
    void Scenario1Question4()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question4Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q4Tayla);
        AudioCoroutine = StartCoroutine(StopAudio(AudioManager.Instance.S1Q4Tayla.length));

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetBool("Talk", true); 
        BlendShape.Instance.Talking();
        isTalking = true;
    }
    void Scenario1Question5()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question5Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q5Tayla);
        AudioCoroutine = StartCoroutine(StopAudio(AudioManager.Instance.S1Q5Tayla.length));

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetBool("Talk", true); 
        BlendShape.Instance.Talking();
        isTalking = true;
    }
    void Scenario1Question6()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question6Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q6Tayla);
        AudioCoroutine = StartCoroutine(StopAudio(AudioManager.Instance.S1Q6Tayla.length));

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetBool("Talk", true); 
        BlendShape.Instance.Talking();
        isTalking = true;
    }
    void Scenario1Question7()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question7Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q7Tayla);
        AudioCoroutine = StartCoroutine(StopAudio(AudioManager.Instance.S1Q7Tayla.length));

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetBool("Talk", true); 
        BlendShape.Instance.Talking();
        isTalking = true;
    }
    void Scenario1Question8()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question8Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q8Tayla);
        AudioCoroutine = StartCoroutine(StopAudio(AudioManager.Instance.S1Q8Tayla.length));

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetBool("Talk", true); 
        BlendShape.Instance.Talking();
        isTalking = true;
    }
    void Scenario1Question9()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question9Box.SetActive(true);
        AudioManager.Instance.PlaySound(AudioManager.Instance.S1Q9Tayla);
        AudioCoroutine = StartCoroutine(StopAudio(AudioManager.Instance.S1Q9Tayla.length));

        //TaylaCam.SetActive(true);
        //PlayerCam.SetActive(false);

        Tayla.GetComponent<Animator>().SetBool("Talk", true); 
        BlendShape.Instance.Talking();
        isTalking = true;
    }
    public void ShowScenario1Question1AnswerBox()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question1Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer1Box.SetActive(true);

        Tayla.GetComponent<Animator>().SetBool("Talk", false);
        Tayla.GetComponent<Animator>().SetTrigger("Idle");
        BlendShape.Instance.Idle();
        isTalking = false;

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);

    }
    public void ShowScenario1Question2AnswerBox()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question2Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer2Box.SetActive(true);

        Tayla.GetComponent<Animator>().SetBool("Talk", false);
        Tayla.GetComponent<Animator>().SetTrigger("Idle");
        BlendShape.Instance.Idle();
        isTalking = false;

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);

    }
    public void ShowScenario1Question3AnswerBox()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question3Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer3Box.SetActive(true);

        Tayla.GetComponent<Animator>().SetBool("Talk", false);
        Tayla.GetComponent<Animator>().SetTrigger("Idle");
        BlendShape.Instance.Idle();
        isTalking = false;

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);

    }
    public void ShowScenario1Question4AnswerBox()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question4Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer4Box.SetActive(true);

        Tayla.GetComponent<Animator>().SetBool("Talk", false);
        Tayla.GetComponent<Animator>().SetTrigger("Idle");
        BlendShape.Instance.Idle();
        isTalking = false;

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void ShowScenario1Question5AnswerBox()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question5Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer5Box.SetActive(true);

        Tayla.GetComponent<Animator>().SetBool("Talk", false);
        Tayla.GetComponent<Animator>().SetTrigger("Idle");
        BlendShape.Instance.Idle();
        isTalking = false;

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void ShowScenario1Question6AnswerBox()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question6Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer6Box.SetActive(true);

        Tayla.GetComponent<Animator>().SetBool("Talk", false);
        Tayla.GetComponent<Animator>().SetTrigger("Idle");
        BlendShape.Instance.Idle();
        isTalking = false;

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void ShowScenario1Question7AnswerBox()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question7Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer7Box.SetActive(true);

        Tayla.GetComponent<Animator>().SetBool("Talk", false);
        Tayla.GetComponent<Animator>().SetTrigger("Idle");
        BlendShape.Instance.Idle();
        isTalking = false;

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void ShowScenario1Question8AnswerBox()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question8Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer8Box.SetActive(true);

        Tayla.GetComponent<Animator>().SetBool("Talk", false);
        Tayla.GetComponent<Animator>().SetTrigger("Idle");
        BlendShape.Instance.Idle();
        isTalking = false;

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void ShowScenario1Question9AnswerBox()
    {
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }

        GameplayUI.Instance.Scenario1Question9Box.SetActive(false);
        GameplayUI.Instance.Scenario1Answer9Box.SetActive(true);

        Tayla.GetComponent<Animator>().SetBool("Talk", false);
        Tayla.GetComponent<Animator>().SetTrigger("Idle");
        BlendShape.Instance.Idle();
        isTalking = false;

        //PlayerCam.SetActive(true);
        //TaylaCam.SetActive(false);
    }
    public void Scenario1Answer1Selected(int answerNumber)
    {
        if (optionSelected) return;

        switch (answerNumber)
        {
            case 1:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
                //AudioManager.Instance.PlaySound(AudioManager.Instance.S1A1APlayer);
                GameplayUI.Instance.Scenario1Answer1Selected(answerNumber);
                break;

            case 2:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
                //AudioManager.Instance.PlaySound(AudioManager.Instance.S1A1BPlayer);
                GameplayUI.Instance.Scenario1Answer1Selected(answerNumber);
                break;

            case 3:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
                //AudioManager.Instance.PlaySound(AudioManager.Instance.S1A1CPlayer);
                GameplayUI.Instance.Scenario1Answer1Selected(answerNumber);
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
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
                //AudioManager.Instance.PlaySound(AudioManager.Instance.S1A2APlayer);
                GameplayUI.Instance.Scenario1Answer2Selected(answerNumber);
                break;

            case 2:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
                //AudioManager.Instance.PlaySound(AudioManager.Instance.S1A2BPlayer);
                GameplayUI.Instance.Scenario1Answer2Selected(answerNumber);
                break;

            case 3:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A2CPlayer);
                GameplayUI.Instance.Scenario1Answer2Selected(answerNumber);
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
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
                //AudioManager.Instance.PlaySound(AudioManager.Instance.S1A3APlayer);
                GameplayUI.Instance.Scenario1Answer3Selected(answerNumber);
                break;

            case 2:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A3BPlayer);
                GameplayUI.Instance.Scenario1Answer3Selected(answerNumber);
                break;

            case 3:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A3CPlayer);
                GameplayUI.Instance.Scenario1Answer3Selected(answerNumber);
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
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A4APlayer);
                GameplayUI.Instance.Scenario1Answer4Selected(answerNumber);
                break;

            case 2:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
              //  AudioManager.Instance.PlaySound(AudioManager.Instance.S1A4BPlayer);
                GameplayUI.Instance.Scenario1Answer4Selected(answerNumber);
                break;

            case 3:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
              //  AudioManager.Instance.PlaySound(AudioManager.Instance.S1A4CPlayer);
                GameplayUI.Instance.Scenario1Answer4Selected(answerNumber);
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
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
             //   AudioManager.Instance.PlaySound(AudioManager.Instance.S1A5APlayer);
                GameplayUI.Instance.Scenario1Answer5Selected(answerNumber);
                break;

            case 2:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
              //  AudioManager.Instance.PlaySound(AudioManager.Instance.S1A5BPlayer);
                GameplayUI.Instance.Scenario1Answer5Selected(answerNumber);
                break;

            case 3:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
              //  AudioManager.Instance.PlaySound(AudioManager.Instance.S1A5CPlayer);
                GameplayUI.Instance.Scenario1Answer5Selected(answerNumber);
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
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
              //  AudioManager.Instance.PlaySound(AudioManager.Instance.S1A6APlayer);
                GameplayUI.Instance.Scenario1Answer6Selected(answerNumber);
                break;

            case 2:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A6BPlayer);
                GameplayUI.Instance.Scenario1Answer6Selected(answerNumber);
                break;

            case 3:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
              //  AudioManager.Instance.PlaySound(AudioManager.Instance.S1A6CPlayer);
                GameplayUI.Instance.Scenario1Answer6Selected(answerNumber);
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
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A7APlayer);
                GameplayUI.Instance.Scenario1Answer7Selected(answerNumber);
                break;

            case 2:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
              //  AudioManager.Instance.PlaySound(AudioManager.Instance.S1A7BPlayer);
                GameplayUI.Instance.Scenario1Answer7Selected(answerNumber);
                break;

            case 3:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A7CPlayer);
                GameplayUI.Instance.Scenario1Answer7Selected(answerNumber);
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
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A8APlayer);
                GameplayUI.Instance.Scenario1Answer8Selected(answerNumber);
                break;

            case 2:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
              //  AudioManager.Instance.PlaySound(AudioManager.Instance.S1A8BPlayer);
                GameplayUI.Instance.Scenario1Answer8Selected(answerNumber);
                break;

            case 3:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A8CPlayer);
                GameplayUI.Instance.Scenario1Answer8Selected(answerNumber);
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
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A9APlayer);
                GameplayUI.Instance.Scenario1Answer9Selected(answerNumber);
                break;

            case 2:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A9BPlayer);
                GameplayUI.Instance.Scenario1Answer9Selected(answerNumber);
                break;

            case 3:
                AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
               // AudioManager.Instance.PlaySound(AudioManager.Instance.S1A9CPlayer);
                GameplayUI.Instance.Scenario1Answer9Selected(answerNumber);
                break;

            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
        currentAnswer = answerNumber;
    }
    public void Scenario1CheckForAnswer()
    {
        GameplayUI.Instance.TurnAnswerSelected(false);
        GameplayUI.Instance.TurnCorrectAnswerColors(true);

        optionSelected = true;
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
        if (currentAnswer == Scenario1CorrectAnswers[currentQuestion])
        {
            Debug.Log("Correct Answer");
            BlendShape.Instance.Smile();
            ScoreManager.Instance.AddScore(1);
        }
        else
        {
            BlendShape.Instance.Sad();
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

        GameplayUI.Instance.TurnCorrectAnswerColors(false);

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
    public void EndGame()
    {
        ScoreManager.Instance.CalculateResults();
        GameplayUI.Instance.SummaryScreen.SetActive(true);
        AudioManager.Instance.StopSound();
    }
    public void EndGameMinusOne()
    {
        ScoreManager.Instance.CalculateResultsMinusOne();
        GameplayUI.Instance.SummaryScreen.SetActive(true);
        AudioManager.Instance.StopSound();
    }
    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
    public void Pause()
    {
        Time.timeScale = 0;
        AudioManager.Instance.StopSound();         if(AudioCoroutine != null)         {             StopCoroutine(AudioCoroutine);         }
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
    IEnumerator StopAudio(float t)
    {
        yield return new WaitForSeconds(t);
        BlendShape.Instance.Idle();
        Tayla.GetComponent<Animator>().SetBool("Talk", false);
    }
}