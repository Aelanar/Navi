using UnityEngine;
using System.Collections;

public class PlayerLightControl : MonoBehaviour
{
    /// <summary>
    /// Classe responsable de l'orientation du spot de lumière : lorsque l'on clic à un endroit la caméra se tourne vers ce point
    /// </summary>

    Ray cameraRay;
    RaycastHit cameraRayHit;



    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(cameraRay, out cameraRayHit))
            {
                Vector3 targetPosition = new Vector3(cameraRayHit.point.x, cameraRayHit.point.y, cameraRayHit.point.z);
                transform.LookAt(targetPosition);
            }
        }

        transform.rotation = Quaternion.Euler(26, transform.rotation.eulerAngles.y, 0);
    }
}
