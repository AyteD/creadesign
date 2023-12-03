using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Tooltip("Le layer du ground.")]
    [SerializeField] private LayerMask _layerMask;

    private Plane _plane = new Plane(Vector3.up, 0);
    private Vector3 _positionToLook;

    // Utilisation de la méthode avec un Plane et donc sans physique. Ne fait pas l'orientation souhaité mais je garde le code en ref car intéressant.
    public void OrientationPlayerWithPlane(Ray cameraRay)
    {
        if(_plane.Raycast(cameraRay, out float distance))
        {
            _positionToLook = cameraRay.GetPoint(distance);
            transform.LookAt(_positionToLook, Vector3.up);
        }    
    }

    public void OrientationPlayerWithPhysics(Ray cameraRay)
    {
        if(Physics.Raycast(cameraRay, out RaycastHit hitInfo, Mathf.Infinity, _layerMask))
        {
            _positionToLook = new Vector3(hitInfo.point.x, transform.position.y, hitInfo.point.z);
            transform.LookAt(_positionToLook, Vector3.up);
        }
    }
}
