using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailingDetect : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 1;
    int MaxDist = 12;
    int MinDist = 2;
    Vector3 checkpoint;
    //org = transform.position;
    public Vector3 org;

    void Start()
    {
        org = transform.position;
        checkpoint = Player.position;
    }

    void Update()
    {
        transform.LookAt(Player);

        if(Player.position.y < 100)
        {
            //Debug.Log("My Text");
            transform.position = org;
        }

        if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.position) <= MinDist)
            {
                //Here Call any function U want Like Shoot at here or something
                Player.position = checkpoint;
                transform.position = org;
                Debug.Log("You just died!");
            }

        }
    }
}
