using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

	// mise en place des positions
	void Start () {
        transformList = this.gameObject.GetComponentInChildren<ListPos>().GetListPos();
        maxPos = transformList.Length;
        positionsList = new Vector3[maxPos];
        for(int i= 0; i < maxPos;i++)
        {
            positionsList[i] = transformList[i].position;
        }
    }


	// Déplcament vers la position target
	void Update () {
        float step = speed * Time.deltaTime;
        Vector3 target = positionsList[pos];
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        if ((transform.position - target).sqrMagnitude < step)
        {
            pos = (pos+1)%maxPos ;
        }
	}
}
