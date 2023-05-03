using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IInteractable
{
    private PlayerHealth _playerHealth;

    private void Start()
    {
        _playerHealth = FindObjectOfType<PlayerHealth>();
    }

    public void Interact()
    {
        _playerHealth.Damage();
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
            Destroy(gameObject);
    }
}
