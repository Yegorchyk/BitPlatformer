using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PatrulEnemy : MonoBehaviour
{
    public int vecNum, lastNum, doorNum;
    public Vector2[] vect;
    public Vector2[] doors;
    public float speed;
    public bool doormove;
    
    void Start()
    {
        vecNum = Random.Range(0, vect.Length);

        
      
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.y % doors[doorNum].y);
       

        if(vect[lastNum].y != vect[vecNum].y)
        {
            Debug.Log("Yes");
            doormove = true;
            transform.position = Vector2.MoveTowards( transform.position, doors[doorNum], speed);
        }
        else /*if(transform.position.y % doors[doorNum].y < 0.05f && transform.position.y % doors[doorNum].y > -0.1f)*/
        {
            Debug.Log("No");
            transform.position = Vector2.MoveTowards(transform.position, vect[vecNum], speed);
        }

        if(Vector2.Distance(transform.position, vect[vecNum]) <= 0.1)
        {
            lastNum = vecNum;
            vecNum = Random.Range(0, vect.Length);
        }

        if(Vector2.Distance(transform.position, doors[doorNum]) <= 0.1 && doormove == true)
        {
            switch (doorNum)
            {
                case 0:
                    doorNum = 1;
                    doormove = false;
                    transform.position = doors[1];
                   

                    break;

                case 1:
                    doorNum = 2;
                    doormove = false;
                    transform.position = doors[2];
                

                    break;

                case 2:

                    doorNum = 0;
                    doormove = false;
                    transform.position = doors[0];
                    
                    break;
            }
        }
    }
}
