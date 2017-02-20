using UnityEngine;
using System.Collections;

public interface LightInteraction {
    /// <summary>
    /// Interface que doivent implémenter les objets qui intéragissent avec les cones de lumières
    /// ATTENTION il faut qu'ils aient aussi le tag LightInteraction !!!!
    /// </summary>


    void Lighted(string color);
}
