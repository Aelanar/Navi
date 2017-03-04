using UnityEngine;
using System.Collections;

public class LightCollider : MonoBehaviour
{
    /// <summary>
    /// Classe qui controle les intéractions entre les lumières et les objets issu de LightInteraction
    /// A attacher au cone de lumière du joueur, au cone de lumière des spots etc....
    /// Fixed update et appeler tous ce qui est en collide ?
    /// </summary>

    private string color;

    void OnTriggerStay(Collider other)
    {
        // Tester si eclairable
        if (other.gameObject.tag == "LightInteraction")
        {
            other.gameObject.GetComponent<LightInteraction>().Lighted(color);
        }
    }
}
