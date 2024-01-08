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

    public GameObject SummaryScreen;
    public Text Score;

    public GameObject TextContainer;
    public GameObject Scenario1;

    public GameObject ExtraPanel;
    public GameObject ExtraPanel2;

    public GameObject Scenario1Question1Box;
    public GameObject Scenario1Answer1Box;
    public GameObject Scenario1Answer1ASelected;
    public GameObject Scenario1Answer1ACorrectSelected;
    public GameObject Scenario1Answer1BSelected;
    public GameObject Scenario1Answer1BCorrectSelected;
    public GameObject Scenario1Answer1CSelected;
    public GameObject Scenario1Answer1CCorrectSelected;
    public GameObject Scenario1Answer1NextButton;

    public GameObject Scenario1Question2Box;
    public GameObject Scenario1Answer2Box;
    public GameObject Scenario1Answer2ASelected;
    public GameObject Scenario1Answer2ACorrectSelected;
    public GameObject Scenario1Answer2BSelected;
    public GameObject Scenario1Answer2BCorrectSelected;
    public GameObject Scenario1Answer2CSelected;
    public GameObject Scenario1Answer2CCorrectSelected;
    public GameObject Scenario1Answer2NextButton;

    public GameObject Scenario1Question3Box;
    public GameObject Scenario1Answer3Box;
    public GameObject Scenario1Answer3ASelected;
    public GameObject Scenario1Answer3ACorrectSelected;
    public GameObject Scenario1Answer3BSelected;
    public GameObject Scenario1Answer3BCorrectSelected;
    public GameObject Scenario1Answer3CSelected;
    public GameObject Scenario1Answer3CCorrectSelected;
    public GameObject Scenario1Answer3NextButton;

    public GameObject Scenario1Question4Box;
    public GameObject Scenario1Answer4Box;
    public GameObject Scenario1Answer4ASelected;
    public GameObject Scenario1Answer4ACorrectSelected;
    public GameObject Scenario1Answer4BSelected;
    public GameObject Scenario1Answer4BCorrectSelected;
    public GameObject Scenario1Answer4CSelected;
    public GameObject Scenario1Answer4CCorrectSelected;
    public GameObject Scenario1Answer4NextButton;

    public GameObject Scenario1Question5Box;
    public GameObject Scenario1Answer5Box;
    public GameObject Scenario1Answer5ASelected;
    public GameObject Scenario1Answer5ACorrectSelected;
    public GameObject Scenario1Answer5BSelected;
    public GameObject Scenario1Answer5BCorrectSelected;
    public GameObject Scenario1Answer5CSelected;
    public GameObject Scenario1Answer5CCorrectSelected;
    public GameObject Scenario1Answer5NextButton;

    public GameObject Scenario1Question6Box;
    public GameObject Scenario1Answer6Box;
    public GameObject Scenario1Answer6ASelected;
    public GameObject Scenario1Answer6ACorrectSelected;
    public GameObject Scenario1Answer6BSelected;
    public GameObject Scenario1Answer6BCorrectSelected;
    public GameObject Scenario1Answer6CSelected;
    public GameObject Scenario1Answer6CCorrectSelected;
    public GameObject Scenario1Answer6NextButton;

    public GameObject Scenario1Question7Box;
    public GameObject Scenario1Answer7Box;
    public GameObject Scenario1Answer7ASelected;
    public GameObject Scenario1Answer7ACorrectSelected;
    public GameObject Scenario1Answer7BSelected;
    public GameObject Scenario1Answer7BCorrectSelected;
    public GameObject Scenario1Answer7CSelected;
    public GameObject Scenario1Answer7CCorrectSelected;
    public GameObject Scenario1Answer7NextButton;

    public GameObject Scenario1Question8Box;
    public GameObject Scenario1Answer8Box;
    public GameObject Scenario1Answer8ASelected;
    public GameObject Scenario1Answer8ACorrectSelected;
    public GameObject Scenario1Answer8BSelected;
    public GameObject Scenario1Answer8BCorrectSelected;
    public GameObject Scenario1Answer8CSelected;
    public GameObject Scenario1Answer8CCorrectSelected;
    public GameObject Scenario1Answer8NextButton;

    public GameObject Scenario1Question9Box;
    public GameObject Scenario1Answer9Box;
    public GameObject Scenario1Answer9ASelected;
    public GameObject Scenario1Answer9ACorrectSelected;
    public GameObject Scenario1Answer9BSelected;
    public GameObject Scenario1Answer9BCorrectSelected;
    public GameObject Scenario1Answer9CSelected;
    public GameObject Scenario1Answer9CCorrectSelected;
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
                if(Scenario1Answer1ASelected)
                Scenario1Answer1ASelected.SetActive(true);
                if(Scenario1Answer1BSelected)
                Scenario1Answer1BSelected.SetActive(false);
                if(Scenario1Answer1CSelected)
                Scenario1Answer1CSelected.SetActive(false);
                Scenario1Answer1NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                if(Scenario1Answer1ASelected)
                Scenario1Answer1ASelected.SetActive(false);
                if(Scenario1Answer1BSelected)
                Scenario1Answer1BSelected.SetActive(true);
                if(Scenario1Answer1CSelected)
                Scenario1Answer1CSelected.SetActive(false);
                Scenario1Answer1NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                if(Scenario1Answer1ASelected)
                Scenario1Answer1ASelected.SetActive(false);
                if(Scenario1Answer1BSelected)
                Scenario1Answer1BSelected.SetActive(false);
                if(Scenario1Answer1CSelected)
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
                if(Scenario1Answer2ASelected)
                Scenario1Answer2ASelected.SetActive(true);
                if(Scenario1Answer2BSelected)
                Scenario1Answer2BSelected.SetActive(false);
                if(Scenario1Answer2CSelected)
                Scenario1Answer2CSelected.SetActive(false);
                Scenario1Answer2NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                if(Scenario1Answer2ASelected)
                Scenario1Answer2ASelected.SetActive(false);
                if(Scenario1Answer2BSelected)
                Scenario1Answer2BSelected.SetActive(true);
                if(Scenario1Answer2CSelected)
                Scenario1Answer2CSelected.SetActive(false);
                Scenario1Answer2NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                if(Scenario1Answer2ASelected)
                Scenario1Answer2ASelected.SetActive(false);
                if(Scenario1Answer2BSelected)
                Scenario1Answer2BSelected.SetActive(false);
                if(Scenario1Answer2CSelected)
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
                if(Scenario1Answer3ASelected)
                Scenario1Answer3ASelected.SetActive(true);
                if(Scenario1Answer3BSelected)
                Scenario1Answer3BSelected.SetActive(false);
                if(Scenario1Answer3CSelected)
                Scenario1Answer3CSelected.SetActive(false);
                Scenario1Answer3NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                if(Scenario1Answer3ASelected)
                Scenario1Answer3ASelected.SetActive(false);
                if(Scenario1Answer3BSelected)
                Scenario1Answer3BSelected.SetActive(true);
                if(Scenario1Answer3CSelected)
                Scenario1Answer3CSelected.SetActive(false);
                Scenario1Answer3NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                if(Scenario1Answer3ASelected)
                Scenario1Answer3ASelected.SetActive(false);
                if(Scenario1Answer3BSelected)
                Scenario1Answer3BSelected.SetActive(false);
                if(Scenario1Answer3CSelected)
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
                if(Scenario1Answer4ASelected)
                Scenario1Answer4ASelected.SetActive(true);
                if(Scenario1Answer4BSelected)
                Scenario1Answer4BSelected.SetActive(false);
                if(Scenario1Answer4CSelected)
                Scenario1Answer4CSelected.SetActive(false);
                Scenario1Answer4NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                if(Scenario1Answer4ASelected)
                Scenario1Answer4ASelected.SetActive(false);
                if(Scenario1Answer4BSelected)
                Scenario1Answer4BSelected.SetActive(true);
                if(Scenario1Answer4CSelected)
                Scenario1Answer4CSelected.SetActive(false);
                Scenario1Answer4NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                if(Scenario1Answer4ASelected)
                Scenario1Answer4ASelected.SetActive(false);
                if(Scenario1Answer4BSelected)
                Scenario1Answer4BSelected.SetActive(false);
                if(Scenario1Answer4CSelected)
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
                if(Scenario1Answer5ASelected)
                Scenario1Answer5ASelected.SetActive(true);
                if(Scenario1Answer5BSelected)
                Scenario1Answer5BSelected.SetActive(false);
                if(Scenario1Answer5CSelected)
                Scenario1Answer5CSelected.SetActive(false);
                Scenario1Answer5NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                if(Scenario1Answer5ASelected)
                Scenario1Answer5ASelected.SetActive(false);
                if(Scenario1Answer5BSelected)
                Scenario1Answer5BSelected.SetActive(true);
                if(Scenario1Answer5CSelected)
                Scenario1Answer5CSelected.SetActive(false);
                Scenario1Answer5NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                if(Scenario1Answer5ASelected)
                Scenario1Answer5ASelected.SetActive(false);
                if(Scenario1Answer5BSelected)
                Scenario1Answer5BSelected.SetActive(false);
                if(Scenario1Answer5CSelected)
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
                if(Scenario1Answer6ASelected)
                Scenario1Answer6ASelected.SetActive(true);
                if(Scenario1Answer6BSelected)
                Scenario1Answer6BSelected.SetActive(false);
                if(Scenario1Answer6CSelected)
                Scenario1Answer6CSelected.SetActive(false);
                Scenario1Answer6NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                if(Scenario1Answer6ASelected)
                Scenario1Answer6ASelected.SetActive(false);
                if(Scenario1Answer6BSelected)
                Scenario1Answer6BSelected.SetActive(true);
                if(Scenario1Answer6CSelected)
                Scenario1Answer6CSelected.SetActive(false);
                Scenario1Answer6NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                if(Scenario1Answer6ASelected)
                Scenario1Answer6ASelected.SetActive(false);
                if(Scenario1Answer6BSelected)
                Scenario1Answer6BSelected.SetActive(false);
                if(Scenario1Answer6CSelected)
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
                if(Scenario1Answer7ASelected)
                Scenario1Answer7ASelected.SetActive(true);
                if(Scenario1Answer7BSelected)
                Scenario1Answer7BSelected.SetActive(false);
                if(Scenario1Answer7CSelected)
                Scenario1Answer7CSelected.SetActive(false);
                Scenario1Answer7NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                if(Scenario1Answer7ASelected)
                Scenario1Answer7ASelected.SetActive(false);
                if(Scenario1Answer7BSelected)
                Scenario1Answer7BSelected.SetActive(true);
                if(Scenario1Answer7CSelected)
                Scenario1Answer7CSelected.SetActive(false);
                Scenario1Answer7NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                if(Scenario1Answer7ASelected)
                Scenario1Answer7ASelected.SetActive(false);
                if(Scenario1Answer7BSelected)
                Scenario1Answer7BSelected.SetActive(false);
                if(Scenario1Answer7CSelected)
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
                if(Scenario1Answer8ASelected)
                Scenario1Answer8ASelected.SetActive(true);
                if(Scenario1Answer8BSelected)
                Scenario1Answer8BSelected.SetActive(false);
                if(Scenario1Answer8CSelected)
                Scenario1Answer8CSelected.SetActive(false);
                Scenario1Answer8NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                if(Scenario1Answer8ASelected)
                Scenario1Answer8ASelected.SetActive(false);
                if(Scenario1Answer8BSelected)
                Scenario1Answer8BSelected.SetActive(true);
                if(Scenario1Answer8CSelected)
                Scenario1Answer8CSelected.SetActive(false);
                Scenario1Answer8NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                if(Scenario1Answer8ASelected)
                Scenario1Answer8ASelected.SetActive(false);
                if(Scenario1Answer8BSelected)
                Scenario1Answer8BSelected.SetActive(false);
                if(Scenario1Answer8CSelected)
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
                if(Scenario1Answer9ASelected)
                Scenario1Answer9ASelected.SetActive(true);
                if(Scenario1Answer9BSelected)
                Scenario1Answer9BSelected.SetActive(false);
                if(Scenario1Answer9CSelected)
                Scenario1Answer9CSelected.SetActive(false);
                Scenario1Answer9NextButton.GetComponent<Button>().interactable = true;
                break;
            case 2:
                if(Scenario1Answer9ASelected)
                Scenario1Answer9ASelected.SetActive(false);
                if(Scenario1Answer9BSelected)
                Scenario1Answer9BSelected.SetActive(true);
                if(Scenario1Answer9CSelected)
                Scenario1Answer9CSelected.SetActive(false);
                Scenario1Answer9NextButton.GetComponent<Button>().interactable = true;
                break;
            case 3:
                if(Scenario1Answer9ASelected)
                Scenario1Answer9ASelected.SetActive(false);
                if(Scenario1Answer9BSelected)
                Scenario1Answer9BSelected.SetActive(false);
                if(Scenario1Answer9CSelected)
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
    public void TurnAnswerSelected(bool b)
    {
        if (Scenario1Answer1ASelected)
            Scenario1Answer1ASelected.SetActive(b);

        if (Scenario1Answer1BSelected)
            Scenario1Answer1BSelected.SetActive(b);

        if (Scenario1Answer1CSelected)
            Scenario1Answer1CSelected.SetActive(b);

        if (Scenario1Answer2ASelected)
            Scenario1Answer2ASelected.SetActive(b);

        if (Scenario1Answer2BSelected)
            Scenario1Answer2BSelected.SetActive(b);

        if (Scenario1Answer2CSelected)
            Scenario1Answer2CSelected.SetActive(b);

        if (Scenario1Answer3ASelected)
            Scenario1Answer3ASelected.SetActive(b);

        if (Scenario1Answer3BSelected)
            Scenario1Answer3BSelected.SetActive(b);

        if (Scenario1Answer3CSelected)
            Scenario1Answer3CSelected.SetActive(b);

        if (Scenario1Answer4ASelected)
            Scenario1Answer4ASelected.SetActive(b);

        if (Scenario1Answer4BSelected)
            Scenario1Answer4BSelected.SetActive(b);

        if (Scenario1Answer4CSelected)
            Scenario1Answer4CSelected.SetActive(b);

        if (Scenario1Answer5ASelected)
            Scenario1Answer5ASelected.SetActive(b);

        if (Scenario1Answer5BSelected)
            Scenario1Answer5BSelected.SetActive(b);

        if (Scenario1Answer5CSelected)
            Scenario1Answer5CSelected.SetActive(b);

        if (Scenario1Answer6ASelected)
            Scenario1Answer6ASelected.SetActive(b);

        if (Scenario1Answer6BSelected)
            Scenario1Answer6BSelected.SetActive(b);

        if (Scenario1Answer6CSelected)
            Scenario1Answer6CSelected.SetActive(b);

        if (Scenario1Answer7ASelected)
            Scenario1Answer7ASelected.SetActive(b);

        if (Scenario1Answer7BSelected)
            Scenario1Answer7BSelected.SetActive(b);

        if (Scenario1Answer7CSelected)
            Scenario1Answer7CSelected.SetActive(b);

        if (Scenario1Answer8ASelected)
            Scenario1Answer8ASelected.SetActive(b);

        if (Scenario1Answer8BSelected)
            Scenario1Answer8BSelected.SetActive(b);

        if (Scenario1Answer8CSelected)
            Scenario1Answer8CSelected.SetActive(b);

        if (Scenario1Answer9ASelected)
            Scenario1Answer9ASelected.SetActive(b);

        if (Scenario1Answer9BSelected)
            Scenario1Answer9BSelected.SetActive(b);

        if (Scenario1Answer9CSelected)
            Scenario1Answer9CSelected.SetActive(b);
    }
    public void TurnCorrectAnswerColors(bool b)
    {
        if (Scenario1Answer1ACorrectSelected)
            Scenario1Answer1ACorrectSelected.SetActive(b);

        if(Scenario1Answer1BCorrectSelected)
            Scenario1Answer1BCorrectSelected.SetActive(b);

        if (Scenario1Answer1CCorrectSelected)
            Scenario1Answer1CCorrectSelected.SetActive(b);

        if (Scenario1Answer2ACorrectSelected)
            Scenario1Answer2ACorrectSelected.SetActive(b);

        if (Scenario1Answer2BCorrectSelected)
            Scenario1Answer2BCorrectSelected.SetActive(b);

        if (Scenario1Answer2CCorrectSelected)
            Scenario1Answer2CCorrectSelected.SetActive(b);

        if (Scenario1Answer3ACorrectSelected)
            Scenario1Answer3ACorrectSelected.SetActive(b);

        if (Scenario1Answer3BCorrectSelected)
            Scenario1Answer3BCorrectSelected.SetActive(b);

        if (Scenario1Answer3CCorrectSelected)
            Scenario1Answer3CCorrectSelected.SetActive(b);

        if (Scenario1Answer4ACorrectSelected)
            Scenario1Answer4ACorrectSelected.SetActive(b);

        if (Scenario1Answer4BCorrectSelected)
            Scenario1Answer4BCorrectSelected.SetActive(b);

        if (Scenario1Answer4CCorrectSelected)
            Scenario1Answer4CCorrectSelected.SetActive(b);

        if (Scenario1Answer5ACorrectSelected)
            Scenario1Answer5ACorrectSelected.SetActive(b);

        if (Scenario1Answer5BCorrectSelected)
            Scenario1Answer5BCorrectSelected.SetActive(b);

        if (Scenario1Answer5CCorrectSelected)
            Scenario1Answer5CCorrectSelected.SetActive(b);

        if (Scenario1Answer6ACorrectSelected)
            Scenario1Answer6ACorrectSelected.SetActive(b);

        if (Scenario1Answer6BCorrectSelected)
            Scenario1Answer6BCorrectSelected.SetActive(b);

        if (Scenario1Answer6CCorrectSelected)
            Scenario1Answer6CCorrectSelected.SetActive(b);

        if (Scenario1Answer7ACorrectSelected)
            Scenario1Answer7ACorrectSelected.SetActive(b);

        if (Scenario1Answer7BCorrectSelected)
            Scenario1Answer7BCorrectSelected.SetActive(b);

        if (Scenario1Answer7CCorrectSelected)
            Scenario1Answer7CCorrectSelected.SetActive(b);

        if (Scenario1Answer8ACorrectSelected)
            Scenario1Answer8ACorrectSelected.SetActive(b);

        if (Scenario1Answer8BCorrectSelected)
            Scenario1Answer8BCorrectSelected.SetActive(b);

        if (Scenario1Answer8CCorrectSelected)
            Scenario1Answer8CCorrectSelected.SetActive(b);

        if (Scenario1Answer9ACorrectSelected)
            Scenario1Answer9ACorrectSelected.SetActive(b);

        if (Scenario1Answer9BCorrectSelected)
            Scenario1Answer9BCorrectSelected.SetActive(b);

        if (Scenario1Answer9CCorrectSelected)
            Scenario1Answer9CCorrectSelected.SetActive(b);
    }
}
