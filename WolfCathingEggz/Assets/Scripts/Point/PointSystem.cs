using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    [SerializeField] private int _points = 0;
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void Update()
    {
        _scoreText.text = "Scores: " + _points.ToString(); 
    }

    public void AddPoint()
    {
        _points++;
    }
}
