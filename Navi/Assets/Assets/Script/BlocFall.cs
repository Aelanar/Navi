using UnityEngine;
using System.Collections;

public class BlocFall : MonoBehaviour {

    /// <summary>
    /// Controle l'arrivé des cubes sur le plateau (vision restreinte)
    /// Les cubes sont envoyé très haut à l'initialisation puis sont remis à leur place dès que le joueur est proche
    /// </summary>


    float detectionRange = 3;
    bool closeEnough = false;
    public Transform player;
    float initialY;

	// Use this for initialization
	void Start () {
        initialY = transform.position.y;
        Vector3 position = new Vector3(transform.position.x, 100, transform.position.z);
        this.transform.position = position;
    }
	
	// Update is called once per frame
	void Update () {
        closeEnough = false;
        Vector2 playerPosition = new Vector2(player.position.x, player.position.z);
        Vector2 blocPosition = new Vector2(transform.position.x, transform.position.z);
        if(Vector2.Distance(playerPosition, blocPosition) < detectionRange)
        {
            closeEnough = true;
        }
        if (closeEnough)
        {
            Vector3 position = new Vector3(transform.position.x, initialY, transform.position.z);
            this.transform.position = position;
        }
    }
}
