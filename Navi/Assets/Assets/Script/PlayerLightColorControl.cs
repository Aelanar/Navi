using UnityEngine;
using System.Collections;

public class PlayerLightColorControl : MonoBehaviour
{
    /// <summary>
    ///Controle du changement de couleur
    /// c = cyan
    /// v = magenta
    /// b = yellow
    /// </summary>


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            gameObject.GetComponent<Light>().color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            gameObject.GetComponent<Light>().color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            gameObject.GetComponent<Light>().color = Color.yellow;
        }
    }
}