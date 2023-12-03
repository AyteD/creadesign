using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private MouseLook _player;
    [SerializeField] private Camera _camera;

    [Tooltip("Définit quel méthode on utilise pour l'orientation du joueur. Mettre à true pour avoir l'orientation voulu.")]
    [SerializeField] private bool _usingPhysics = true;

    private void Start()
    {
        _camera.GetComponent<SmoothFollow>().SetNewTarget(_player.gameObject);
    }

    private void Update()
    {
        Ray cameraRay = _camera.ScreenPointToRay(Input.mousePosition);

        if (_usingPhysics)
        {
            _player.OrientationPlayerWithPhysics(cameraRay);
        }
        else
        {
            _player.OrientationPlayerWithPlane(cameraRay);
        }
        
    }
}
