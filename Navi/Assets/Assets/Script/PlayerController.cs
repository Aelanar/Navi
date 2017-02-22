using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// Controle les déplacements du joueur grâce à la physique
    /// On change la velocity du joueur
    /// </summary>


    // Vitesse du joueur
    float speed = 2F;

    // Touches pour se déplacer
    KeyCode keyUp = KeyCode.Z;
    KeyCode keyDown = KeyCode.S;
    KeyCode keyLeft = KeyCode.Q;
    KeyCode keyRight = KeyCode.D;


    //rigidbody responsable de la physique du joueur
    Rigidbody rb;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }



    void FixedUpdate()
    {
        if (Input.GetKey(keyUp))
        {
            rb.velocity = new Vector3(speed, 0.0f, rb.velocity.z);

        }
        if (Input.GetKey(keyDown))
        {
            rb.velocity = new Vector3(-speed, 0.0f, rb.velocity.z);
        }
        if (Input.GetKey(keyLeft))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0.0f, speed);
        }
        if (Input.GetKey(keyRight))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0.0f, -speed);
        }
        if (!Input.GetKey(keyUp) && !Input.GetKey(keyDown))
        {
            rb.velocity = new Vector3(0.0f, 0.0f, rb.velocity.z);
        }
        if (!Input.GetKey(keyLeft) && !Input.GetKey(keyRight))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0.0f, 0.0f);
        }
    }
}
