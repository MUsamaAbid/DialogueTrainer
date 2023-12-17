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
    public GameObject Scenario1Answer1NextButton;

    public GameObject Scenario1Question2Box;
    public GameObject Scenario1Answer2Box;
    public GameObject Scenario1Answer2ASelected;
    public GameObject Scenario1Answer2BSelected;
    public GameObject Scenario1Answer2CSelected;
    public GameObject Scenario1Answer2NextButton;

    public GameObject Scenario1Question3Box;
    public GameObject Scenario1Answer3Box;
    public GameObject Scenario1Answer3ASelected;
    public GameObject Scenario1Answer3BSelected;
    public GameObject Scenario1Answer3CSelected;
    public GameObject Scenario1Answer3NextButton;

    public void Scenario1Answer1Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                Scenario1Answer1ASelected.SetActive(true);
                Scenario1Answer1BSelected.SetActive(false);
                Scenario1Answer1CSelected.SetActive(false);
                Scenario1Answer1NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                Scenario1Answer1ASelected.SetActive(false);
                Scenario1Answer1BSelected.SetActive(true);
                Scenario1Answer1CSelected.SetActive(false);
                Scenario1Answer1NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                Scenario1Answer1ASelected.SetActive(false);
                Scenario1Answer1BSelected.SetActive(false);
                Scenario1Answer1CSelected.SetActive(true);
                Scenario1Answer1NextButton.GetComponent<Button>().interactable = true;
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
    public void TurnQuestion1UIOff()
    {
        Scenario1Question1Box.SetActive(false);
        Scenario1Answer1Box.SetActive(false);
    }
    public void Scenario1Answer2Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                Scenario1Answer2ASelected.SetActive(true);
                Scenario1Answer2BSelected.SetActive(false);
                Scenario1Answer2CSelected.SetActive(false);
                Scenario1Answer2NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                Scenario1Answer2ASelected.SetActive(false);
                Scenario1Answer2BSelected.SetActive(true);
                Scenario1Answer2CSelected.SetActive(false);
                Scenario1Answer2NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                Scenario1Answer2ASelected.SetActive(false);
                Scenario1Answer2BSelected.SetActive(false);
                Scenario1Answer2CSelected.SetActive(true);
                Scenario1Answer2NextButton.GetComponent<Button>().interactable = true;
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
    public void TurnQuestion2UIOff()
    {
        Scenario1Question2Box.SetActive(false);
        Scenario1Answer2Box.SetActive(false);
    }
    public void Scenario1Answer3Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                Scenario1Answer3ASelected.SetActive(true);
                Scenario1Answer3BSelected.SetActive(false);
                Scenario1Answer3CSelected.SetActive(false);
                Scenario1Answer3NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                Scenario1Answer3ASelected.SetActive(false);
                Scenario1Answer3BSelected.SetActive(true);
                Scenario1Answer3CSelected.SetActive(false);
                Scenario1Answer3NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                Scenario1Answer3ASelected.SetActive(false);
                Scenario1Answer3BSelected.SetActive(false);
                Scenario1Answer3CSelected.SetActive(true);
                Scenario1Answer3NextButton.GetComponent<Button>().interactable = true;
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
    public void TurnQuestion3UIOff()
    {
        Scenario1Question3Box.SetActive(false);
        Scenario1Answer3Box.SetActive(false);
    }
    public void AnswerNextButtonInteractables()
    {
        Scenario1Answer1NextButton.GetComponent<Button>().interactable = false;
        Scenario1Answer2NextButton.GetComponent<Button>().interactable = false;
        Scenario1Answer3NextButton.GetComponent<Button>().interactable = false;
    }
}
