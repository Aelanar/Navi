using UnityEngine;
using System.Collections;

public class CubeMelting : MonoBehaviour, LightInteraction
{
    /// <summary>
    /// Objet CubeMelting : Lighted décompte un compteur, lorsqu'il atteint 0 le cube disparait
    /// </summary>


    public float lifeTime;
    GameObject obj;


    void Start()
    {
        obj = this.gameObject;
    }


    public void Lighted(string color)
    {
        lifeTime -= 1;
        if (lifeTime < 0)
        {
            obj.SetActive(false);
        }
    }
}