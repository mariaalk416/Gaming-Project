using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Pathfinding;

public class EnemyAI : MonoBehaviour
{
    public Transform target;

    public float speed = 200f;
    public float nextWaypointDistance = 3f;


    //Seeker seeker;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        

        /*if(target){
            seeker.StartPath(rb.position, target.position, OnPathComplete);
        }*/
    }

    /*void OnPathComplete (Path p){
        if(!p.error){
            //path = p;
            currentWaypoint = 0;
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
