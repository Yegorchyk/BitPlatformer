using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PatrulEnemy : MonoBehaviour
{
    public int vecNum;
    public Vector2[] vect;
    public float speed;

    void Start()
    {
        vecNum = Random.Range(0, vect.Length);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(vecNum);
        transform.position = Vector2.MoveTowards(transform.position, vect[vecNum], speed);

        if(Vector2.Distance(transform.position, vect[vecNum]) <= 0.1)
        {
            vecNum = Random.Range(0, vect.Length);
        }
    }
}
