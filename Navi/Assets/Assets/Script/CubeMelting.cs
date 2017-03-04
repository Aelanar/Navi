using UnityEngine;
using System.Collections;

public class CubeMelting : MonoBehaviour, LightInteraction
{
    /// <summary>
    /// Objet CubeMelting : Lighted décompte un compteur, lorsqu'il atteint 0 le cube disparait
    /// </summary>


    public float lifeTime;
    GameObject obj;
    Renderer rend;

    void Start()
    {
        obj = this.gameObject;
        rend = this.GetComponent<Renderer>();
    }


    void Fade()
    {
        Color c = rend.material.color;
        c.a = c.a*0.99f;
        rend.material.color = c;
        }
    


    public void Lighted(string color)
    {

        lifeTime -= 1;
        Fade();
        if (lifeTime < 0)
        {
            obj.SetActive(false);
        }
    }
}
