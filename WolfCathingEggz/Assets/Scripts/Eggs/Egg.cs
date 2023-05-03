using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour, IInteractable
{
    private PointSystem _pointSystem;
    private PlayerHealth _playerHealth;

    private void Start()
    {
        _pointSystem = FindObjectOfType<PointSystem>();
        _playerHealth = FindObjectOfType<PlayerHealth>();
    }

    public void Interact()
    {
        _pointSystem.AddPoint();
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            Destroy(gameObject);
            _playerHealth.Damage();
        }
    }
}
