using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _leaderboardButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private Button _easyButton;
    [SerializeField] private Button _mediumButton;
    [SerializeField] private Button _hardButton;
    [SerializeField] private Button _backButton;

    [Header("Panels")]
    [SerializeField] private GameObject _levelPanel;
    [SerializeField] private GameObject _mainPanel;

    private void Start()
    {
        _playButton.onClick.AddListener(ChooseLevel);
        _leaderboardButton.onClick.AddListener(GoToLeaders);
        _quitButton.onClick.AddListener(Quit);
        _easyButton.onClick.AddListener(() => StartGame(1f));
        _mediumButton.onClick.AddListener(() => StartGame(2f));
        _hardButton.onClick.AddListener(() => StartGame(3f));
        _backButton.onClick.AddListener(GoBack);
    }

    private void GoBack()
    {
        _levelPanel.SetActive(false);
        _mainPanel.SetActive(true);
    }

    private void StartGame(float time)
    {
        SceneManager.LoadScene(1);
        Time.timeScale = time;
    }

    private void Quit()
    {
        Application.Quit();
    }

    private void GoToLeaders()
    {
        Debug.Log("Go to Leaderboard");
    }

    private void ChooseLevel()
    {
        _levelPanel.SetActive(true);
        _mainPanel.SetActive(false);
    }
}
