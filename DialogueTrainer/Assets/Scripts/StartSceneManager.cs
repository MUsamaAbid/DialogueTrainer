using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    [SerializeField] InputField IdInput;
    [SerializeField] GameObject SubmitButton;

    [SerializeField] Text Scene1Score;
    [SerializeField] Text Scene2Score;
    [SerializeField] Text Scene3Score;
    [SerializeField] Text Scene4Score;
    [SerializeField] Text Scene5Score;
    [SerializeField] Text Scene6Score;

    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void OnInputIDValueChange()
    {
        if(IdInput.text.Length == 4)
        {
            SubmitButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            SubmitButton.GetComponent<Button>().interactable = false;
        }
    }
    public void LoadScores()
    {
        if (PlayerPrefs.GetString("SceneNumber1") == "")
        {
            Scene1Score.text = "Incomplete";
        }
        else
        {
            Scene1Score.text = ConvertStringToInt(PlayerPrefs.GetString("SceneNumber1")).ToString() + "%";
        }

        if (PlayerPrefs.GetString("SceneNumber2") == "")
        {
            Scene2Score.text = "Incomplete";
        }
        else
        {
            Scene2Score.text = ConvertStringToInt(PlayerPrefs.GetString("SceneNumber2")).ToString() + "%";
        }

        if (PlayerPrefs.GetString("SceneNumber3") == "")
        {
            Scene3Score.text = "Incomplete";
        }
        else
        {
            Scene3Score.text = ConvertStringToInt(PlayerPrefs.GetString("SceneNumber3")).ToString() + "%";
        }

        if (PlayerPrefs.GetString("SceneNumber4") == "")
        {
            Scene4Score.text = "Incomplete";
        }
        else
        {
            Scene4Score.text = ConvertStringToInt(PlayerPrefs.GetString("SceneNumber4")).ToString() + "%";
        }

        if (PlayerPrefs.GetString("SceneNumber5") == "")
        {
            Scene5Score.text = "Incomplete";
        }
        else
        {
            Scene5Score.text = ConvertStringToInt(PlayerPrefs.GetString("SceneNumber5")).ToString() + "%";
        }

        if (PlayerPrefs.GetString("SceneNumber6") == "")
        {
            Scene6Score.text = "Incomplete";
        }
        else
        {
            Scene6Score.text = ConvertStringToInt(PlayerPrefs.GetString("SceneNumber6")).ToString() + "%";
        }
    }
    int ConvertStringToInt(string input)
    {
        if (float.TryParse(input, out float floatValue))
        {
            // Conversion to float successful
            int intValue = Mathf.RoundToInt(floatValue);
            // Conversion to int successful
            return intValue;
        }
        else
        {
            // Conversion to float failed, handle the error
            Debug.LogError("Unable to convert the string to a float.");
            return 0; // or any default value based on your requirements
        }
    }
}
