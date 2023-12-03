using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [Tooltip("Permet d'adoucir le suivie de la caméra. A zéro le suivie n'est pas adouci.")]
    [SerializeField] private float _smoothTime = 0.1f;

    private Vector3 _offset; // est la position de la caméra par rapport au player.
    private GameObject _target;
    private Vector3 _currentVelocity = Vector3.zero; // C'est une ref de vitesse pour le SmoothDamp qu'on utilise.

    public void SetNewTarget(GameObject newTarget)
    {
        _target = newTarget;
        SetOffset();
    }

    // Important de bien placé la caméra par rapport au player dans la scène.
    private void SetOffset()
    {
        _offset = transform.position - _target.transform.position;
    }

    private void LateUpdate()
    {
        // On traque la position du player tout le temps pour le suivre.
        Vector3 targetPosition = _target.transform.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, _smoothTime);
    }
}
