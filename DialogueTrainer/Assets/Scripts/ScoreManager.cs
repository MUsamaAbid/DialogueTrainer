using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    #region Instance
    public static ScoreManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public int totalScore;

    public void AddScore(int s)
    {
        totalScore += s;
        GameplayUI.Instance.UpdateScore(totalScore);
    }

    public void CalculateResults()
    {
        float answered = totalScore;
        float numberOfQuestions = GameplayManager.Instance.NumberOfQuestions;

        float percentage = (answered / numberOfQuestions) * 100;

        GameplayUI.Instance.Score.text = percentage.ToString() + "%";
    }
    public void CalculateResultsMinusOne()
    {
        float answered = totalScore;
        float numberOfQuestions = GameplayManager.Instance.NumberOfQuestions - 1;

        float percentage = (answered / numberOfQuestions) * 100;

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        PlayerPrefs.SetString("SceneNumber" + currentSceneIndex.ToString(), percentage.ToString());
        Debug.Log("Prefs set: " + PlayerPrefs.GetString("SceneNumber" + currentSceneIndex.ToString()));

        GameplayUI.Instance.Score.text = percentage.ToString() + "%";
    }
}
