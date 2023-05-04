using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _finalScoreText;
    [SerializeField] private Button _backToMenuButton;
    [SerializeField] private PointSystem _pointSystem;

    private void Start()
    {
        _backToMenuButton.onClick.AddListener(BackToMenu);    
    }

    private void Update()
    {
        _finalScoreText.text = "Final Score: " + _pointSystem.GetPoints().ToString();
    }

    private void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
