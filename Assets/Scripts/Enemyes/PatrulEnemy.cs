using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PatrulEnemy : MonoBehaviour
{
    public int vecNum, doorNum;
    public Vector2[] vect;
    public Vector2[] doors;
    public float speed;

    
    void Start()
    {
        vecNum = Random.Range(0, vect.Length);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(vecNum);
       

        if(transform.position.y - vect[vecNum].y > 1)
        {
            transform.position = Vector2.MoveTowards( transform.position, doors[doorNum], speed);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, vect[vecNum], speed);
        }

        if(Vector2.Distance(transform.position, vect[vecNum]) <= 0.1)
        {
            vecNum = Random.Range(0, vect.Length);
        }

        if(Vector2.Distance(transform.position, doors[doorNum]) <= 0.1)
        {
            if(vecNum < 2)
            {
                transform.position = doors[2];
            }
        }
    }
}
