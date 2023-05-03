using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _playerAnimator;

    public void GoUp()
    {
        _playerAnimator.SetBool("Up", true);
        _playerAnimator.SetBool("Down", false);
    }

    public void GoDown()
    {
        _playerAnimator.SetBool("Up", false);
        _playerAnimator.SetBool("Down", true);
    }
}
