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
    public Text Score;

    public GameObject TextContainer;
    public GameObject Scenario1;

    public GameObject ExtraPanel;

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

    public GameObject Scenario1Question4Box;
    public GameObject Scenario1Answer4Box;
    public GameObject Scenario1Answer4ASelected;
    public GameObject Scenario1Answer4BSelected;
    public GameObject Scenario1Answer4CSelected;
    public GameObject Scenario1Answer4NextButton;

    public GameObject Scenario1Question5Box;
    public GameObject Scenario1Answer5Box;
    public GameObject Scenario1Answer5ASelected;
    public GameObject Scenario1Answer5BSelected;
    public GameObject Scenario1Answer5CSelected;
    public GameObject Scenario1Answer5NextButton;

    public GameObject Scenario1Question6Box;
    public GameObject Scenario1Answer6Box;
    public GameObject Scenario1Answer6ASelected;
    public GameObject Scenario1Answer6BSelected;
    public GameObject Scenario1Answer6CSelected;
    public GameObject Scenario1Answer6NextButton;

    public GameObject Scenario1Question7Box;
    public GameObject Scenario1Answer7Box;
    public GameObject Scenario1Answer7ASelected;
    public GameObject Scenario1Answer7BSelected;
    public GameObject Scenario1Answer7CSelected;
    public GameObject Scenario1Answer7NextButton;

    public GameObject Scenario1Question8Box;
    public GameObject Scenario1Answer8Box;
    public GameObject Scenario1Answer8ASelected;
    public GameObject Scenario1Answer8BSelected;
    public GameObject Scenario1Answer8CSelected;
    public GameObject Scenario1Answer8NextButton;

    public GameObject Scenario1Question9Box;
    public GameObject Scenario1Answer9Box;
    public GameObject Scenario1Answer9ASelected;
    public GameObject Scenario1Answer9BSelected;
    public GameObject Scenario1Answer9CSelected;
    public GameObject Scenario1Answer9NextButton;

    public void TurnOffExtraPanel()
    {
        ExtraPanel.SetActive(false);
    }
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
        if (Scenario1Question1Box)
        Scenario1Question1Box.SetActive(false);
        if (Scenario1Answer1Box)
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
        if (Scenario1Question2Box)
        Scenario1Question2Box.SetActive(false);
        if (Scenario1Answer2Box)
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
        if (Scenario1Question3Box)
        Scenario1Question3Box.SetActive(false);
        if (Scenario1Answer3Box)
        Scenario1Answer3Box.SetActive(false);
    }
    public void Scenario1Answer4Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                Scenario1Answer4ASelected.SetActive(true);
                Scenario1Answer4BSelected.SetActive(false);
                Scenario1Answer4CSelected.SetActive(false);
                Scenario1Answer4NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                Scenario1Answer4ASelected.SetActive(false);
                Scenario1Answer4BSelected.SetActive(true);
                Scenario1Answer4CSelected.SetActive(false);
                Scenario1Answer4NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                Scenario1Answer4ASelected.SetActive(false);
                Scenario1Answer4BSelected.SetActive(false);
                Scenario1Answer4CSelected.SetActive(true);
                Scenario1Answer4NextButton.GetComponent<Button>().interactable = true;
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
    public void TurnQuestion4UIOff()
    {
        if (Scenario1Question4Box)
        Scenario1Question4Box.SetActive(false);
        if (Scenario1Answer4Box)
        Scenario1Answer4Box.SetActive(false);
    }
    public void Scenario1Answer5Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                Scenario1Answer5ASelected.SetActive(true);
                Scenario1Answer5BSelected.SetActive(false);
                Scenario1Answer5CSelected.SetActive(false);
                Scenario1Answer5NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                Scenario1Answer5ASelected.SetActive(false);
                Scenario1Answer5BSelected.SetActive(true);
                Scenario1Answer5CSelected.SetActive(false);
                Scenario1Answer5NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                Scenario1Answer5ASelected.SetActive(false);
                Scenario1Answer5BSelected.SetActive(false);
                Scenario1Answer5CSelected.SetActive(true);
                Scenario1Answer5NextButton.GetComponent<Button>().interactable = true;
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
    public void TurnQuestion5UIOff()
    {
        if (Scenario1Question5Box)
        Scenario1Question5Box.SetActive(false);
        if (Scenario1Answer5Box)
        Scenario1Answer5Box.SetActive(false);
    }
    public void Scenario1Answer6Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                Scenario1Answer6ASelected.SetActive(true);
                Scenario1Answer6BSelected.SetActive(false);
                Scenario1Answer6CSelected.SetActive(false);
                Scenario1Answer6NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                Scenario1Answer6ASelected.SetActive(false);
                Scenario1Answer6BSelected.SetActive(true);
                Scenario1Answer6CSelected.SetActive(false);
                Scenario1Answer6NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                Scenario1Answer6ASelected.SetActive(false);
                Scenario1Answer6BSelected.SetActive(false);
                Scenario1Answer6CSelected.SetActive(true);
                Scenario1Answer6NextButton.GetComponent<Button>().interactable = true;
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
    public void TurnQuestion6UIOff()
    {
        if (Scenario1Question6Box)
        Scenario1Question6Box.SetActive(false);
        if (Scenario1Answer6Box)
        Scenario1Answer6Box.SetActive(false);
    }
    public void Scenario1Answer7Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                Scenario1Answer7ASelected.SetActive(true);
                Scenario1Answer7BSelected.SetActive(false);
                Scenario1Answer7CSelected.SetActive(false);
                Scenario1Answer7NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                Scenario1Answer7ASelected.SetActive(false);
                Scenario1Answer7BSelected.SetActive(true);
                Scenario1Answer7CSelected.SetActive(false);
                Scenario1Answer7NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                Scenario1Answer7ASelected.SetActive(false);
                Scenario1Answer7BSelected.SetActive(false);
                Scenario1Answer7CSelected.SetActive(true);
                Scenario1Answer7NextButton.GetComponent<Button>().interactable = true;
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
    public void TurnQuestion7UIOff()
    {
        if (Scenario1Question7Box)
            Scenario1Question7Box.SetActive(false);

        if (Scenario1Answer7Box)
            Scenario1Answer7Box.SetActive(false);
    }
    public void Scenario1Answer8Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                Scenario1Answer8ASelected.SetActive(true);
                Scenario1Answer8BSelected.SetActive(false);
                Scenario1Answer8CSelected.SetActive(false);
                Scenario1Answer8NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                Scenario1Answer8ASelected.SetActive(false);
                Scenario1Answer8BSelected.SetActive(true);
                Scenario1Answer8CSelected.SetActive(false);
                Scenario1Answer8NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                Scenario1Answer8ASelected.SetActive(false);
                Scenario1Answer8BSelected.SetActive(false);
                Scenario1Answer8CSelected.SetActive(true);
                Scenario1Answer8NextButton.GetComponent<Button>().interactable = true;
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
    public void TurnQuestion8UIOff()
    {
        if(Scenario1Question8Box)
        Scenario1Question8Box.SetActive(false);

        if(Scenario1Answer8Box)
        Scenario1Answer8Box.SetActive(false);
    }
    public void Scenario1Answer9Selected(int answerNumber)
    {
        switch (answerNumber)
        {
            case 1:
                Scenario1Answer9ASelected.SetActive(true);
                Scenario1Answer9BSelected.SetActive(false);
                Scenario1Answer9CSelected.SetActive(false);
                Scenario1Answer9NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                Scenario1Answer9ASelected.SetActive(false);
                Scenario1Answer9BSelected.SetActive(true);
                Scenario1Answer9CSelected.SetActive(false);
                Scenario1Answer9NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                Scenario1Answer9ASelected.SetActive(false);
                Scenario1Answer9BSelected.SetActive(false);
                Scenario1Answer9CSelected.SetActive(true);
                Scenario1Answer9NextButton.GetComponent<Button>().interactable = true;
                break;
            default:
                Debug.LogError("No AUDIO for the answer");
                break;
        }
    }
    public void TurnQuestion9UIOff()
    {
        if (Scenario1Question9Box)
            Scenario1Question9Box.SetActive(false);

        if (Scenario1Answer9Box)
            Scenario1Answer9Box.SetActive(false);
    }
    public void AnswerNextButtonInteractables()
    {
        if(Scenario1Answer1NextButton)
            Scenario1Answer1NextButton.GetComponent<Button>().interactable = false;
        if(Scenario1Answer2NextButton)
            Scenario1Answer2NextButton.GetComponent<Button>().interactable = false;
        if(Scenario1Answer3NextButton)
            Scenario1Answer3NextButton.GetComponent<Button>().interactable = false;
        if(Scenario1Answer4NextButton)
            Scenario1Answer4NextButton.GetComponent<Button>().interactable = false;
        if(Scenario1Answer5NextButton)
            Scenario1Answer5NextButton.GetComponent<Button>().interactable = false;
        if(Scenario1Answer6NextButton)
            Scenario1Answer6NextButton.GetComponent<Button>().interactable = false;
        if(Scenario1Answer7NextButton)
            Scenario1Answer7NextButton.GetComponent<Button>().interactable = false;
        if(Scenario1Answer8NextButton)
            Scenario1Answer8NextButton.GetComponent<Button>().interactable = false;
    }
    public void UpdateScore(int s)
    {
        Score.text = "Score: " + s.ToString();
    }
}
