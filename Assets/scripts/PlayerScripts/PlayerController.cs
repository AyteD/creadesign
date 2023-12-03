using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _gravityPower = 20f;

    private Vector3 _directionMove;
    private float _maxLength = 1f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        DirectionVector(horizontal, vertical);

        if (!_controller.isGrounded)
        {
            ApplyGravity();
        }

        PlayerMovement();
    }

    private void PlayerMovement()
    {
        _controller.Move(_directionMove);
    }

    private void ApplyGravity()
    {
        _directionMove.y += -_gravityPower * Time.deltaTime;
    }

    private void DirectionVector(float horizontal, float vertical)
    {
        _directionMove = new Vector3(horizontal, 0, vertical);

        // ClampMagnitude permet de spécifier à quel longueur on veut que la magnitude du vecteur soit. Pareil que .normalized si on veut une magnitude de 1.
        _directionMove = Vector3.ClampMagnitude(_directionMove, _maxLength) * _speed * Time.deltaTime;
    }
}
