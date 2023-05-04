using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _playerHealth;
    [SerializeField] List<GameObject> _healthBar;
    [SerializeField] GameObject _loseMenu;

    public void Damage()
    {
        _playerHealth--;
        _healthBar[2 - _playerHealth].SetActive(false);

        if (_playerHealth <= 0)
            Die();
    }

    private void Die()
    {
        //Lose UI Screen it appearing
        Time.timeScale = 0;
        _loseMenu.SetActive(true);

        //Points saved to the file
    }
}
