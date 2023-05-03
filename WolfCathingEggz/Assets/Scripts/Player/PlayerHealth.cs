using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _playerHealth;

    public void Damage()
    {
        _playerHealth--;

        if (_playerHealth <= 0)
            Die();
    }

    private void Die()
    {
        //Lose UI Screen it appearing
        //Points saved to the file
        Debug.Log("you dead!");
    }
}
