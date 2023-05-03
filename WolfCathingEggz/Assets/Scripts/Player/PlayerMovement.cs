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
                _basketPoint.localPosition = new Vector2(-0.55f, -0.55f);
            else
                _basketPoint.localPosition = new Vector2(1.3f, -0.55f);
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
    }

    private void OnDrawGizmosSelected()
    {
        if (!_basketPoint)
            return;

        Gizmos.DrawWireSphere(_basketPoint.position, basketRadius);
    }
}
