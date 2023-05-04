using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    [SerializeField] private int _points = 0;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    private void Start()
    {
        _highScoreText.text = "Highest Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    private void Update()
    {
        _scoreText.text = "Scores: " + _points.ToString();
    }

    public void AddPoint()
    {
        _points++;

        if (_points > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", _points);
            _highScoreText.text = "Highest Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }

    public int GetPoints()
    {
        return _points;
    }
}
