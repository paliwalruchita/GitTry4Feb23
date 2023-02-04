using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWP : MonoBehaviour
{
    public GameObject[] wayPoints;
    public float speed = 3f;
    int currentIndex = 0;
    void Start()
    {
        transform.position = wayPoints[currentIndex].transform.position;
    }

    //Now we create a method to move player and then call it in Update
    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position , wayPoints[currentIndex].transform.position, speed*Time.deltaTime);
        //Now check if player reached to its nearest destination
        if (transform.position == wayPoints[currentIndex].transform.position)
            currentIndex++;
        if (currentIndex == wayPoints.Length)
            currentIndex = 0;
    }
}
