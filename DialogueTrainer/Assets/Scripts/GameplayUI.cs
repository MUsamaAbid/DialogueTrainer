using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayUI : MonoBehaviour
{
    #region Instance
    public static GameplayUI Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public GameObject TextContainer;
    public GameObject Scenario1;

    public GameObject Scenario1Question1Box;
    public GameObject Scenario1Answer1Box;
    public GameObject Scenario1Answer1ASelected;
    public GameObject Scenario1Answer1BSelected;
    public GameObject Scenario1Answer1CSelected;

    public GameObject Scenario1AnswerNextButton;

    public GameObject Scenario1Question2Box;
    public GameObject Scenario1Answer2Box;
    public GameObject Scenario1Answer2ASelected;
    public GameObject Scenario1Answer2BSelected;
    public GameObject Scenario1Answer2CSelected;

    public void ShowQuestion(int questionNumber)
    {
        switch (questionNumber)
        {
            case 0:
                Scenario1Question1Box.SetActive(true);
                break;
            case 1:
                //Scenario2Questions.SetActive(true);
                break;
        }
    }
    public void Scenario1Answer1Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                Scenario1Answer1ASelected.SetActive(true);
                Scenario1Answer1BSelected.SetActive(false);
                Scenario1Answer1CSelected.SetActive(false);
                Scenario1AnswerNextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                Scenario1Answer1ASelected.SetActive(false);
                Scenario1Answer1BSelected.SetActive(true);
                Scenario1Answer1CSelected.SetActive(false);
                Scenario1AnswerNextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                Scenario1Answer1ASelected.SetActive(false);
                Scenario1Answer1BSelected.SetActive(false);
                Scenario1Answer1CSelected.SetActive(true);
                Scenario1AnswerNextButton.GetComponent<Button>().interactable = true;
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
    public void AnswerNextButtonInteractables()
    {
        Scenario1AnswerNextButton.GetComponent<Button>().interactable = false;
    }
}
