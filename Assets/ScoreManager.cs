using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _txt;
    [SerializeField] TextMeshProUGUI _txtEndScreen;

    [Header("Debug")]
    [SerializeField] int _currentScore;

    public static ScoreManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }


    public void AddScore(int amount)
    {
        _currentScore += amount;
        _txt.text = _currentScore.ToString();
        _txtEndScreen.text = _currentScore.ToString();
    }


}
