using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
    /// <summary>
    /// Implémentation du comportement patrol :
    /// On recupère la liste de positions des objets enfants et on va successivement à chacune de ces positions
    /// </summary>
    
    private Transform[] transformList;
    private Vector3[] positionsList;
    private int pos=0;
    private int maxPos;
    public float speed=1;
    
    // Le navMeshAgent s'occupe du pathfinding
    NavMeshAgent agent;

    // mise en place des positions
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        transformList = this.gameObject.GetComponentInChildren<ListPos>().GetListPos();
        maxPos = transformList.Length;
        positionsList = new Vector3[maxPos];
        for (int i= 0; i < maxPos;i++)
        {
            positionsList[i] = transformList[i].position;
        }
    }


	// Déplcament vers la position target
	void Update () {
        float precision = 1;
        Vector3 target = positionsList[pos];
        agent.destination = target;
        print((transform.position - target).sqrMagnitude );
        if ((transform.position - target).sqrMagnitude < precision)
        {
            pos = (pos+1)%maxPos ;
        }
	}
}
