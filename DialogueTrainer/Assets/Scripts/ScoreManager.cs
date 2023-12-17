using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
