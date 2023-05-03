using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private SpriteRenderer _playerSpriteRenderer;
    [SerializeField] private Transform _basketPoint;
    [SerializeField] private float basketRadius = 5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Q))
        {
            _playerAnimation.GoUp();
            _playerSpriteRenderer.flipX = Input.GetKeyDown(KeyCode.Q);

            if (_playerSpriteRenderer.flipX)
                _basketPoint.localPosition = new Vector2(-0.45f, -0.32f);
            else
                _basketPoint.localPosition = new Vector2(1.24f, -0.3f);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
        {
            _playerAnimation.GoDown();
            _playerSpriteRenderer.flipX = Input.GetKeyDown(KeyCode.A);

            if (_playerSpriteRenderer.flipX)
                _basketPoint.localPosition = new Vector2(-0.4f, -1.15f);
            else
                _basketPoint.localPosition = new Vector2(1.15f, -1.15f);
        }

        CatchObjects();
    }

    private void OnDrawGizmosSelected()
    {
        if (!_basketPoint)
            return;

        Gizmos.DrawWireSphere(_basketPoint.position, basketRadius);
    }

    private void CatchObjects()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(_basketPoint.position, basketRadius);

        if (objects.Length == 0)
            return;
                
        foreach (Collider2D obj in objects)
        {
            obj.GetComponent<IInteractable>().Interact();
        }
    }
}
