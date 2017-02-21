using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPos : MonoBehaviour
{/// <summary>
/// Classe qui recupère la liste des positions de ses enfants
/// </summary>
    public Transform[] GetListPos()
    {
        Transform[]  positions = this.GetComponentsInChildren<Transform>();
        return positions;
    }
}