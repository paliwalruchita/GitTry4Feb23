using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentIndex = 0;
    float speed = 3f;
    private void Start()
    {
        transform.position = waypoints[currentIndex].transform.position;
    }
    private void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentIndex].transform.position, speed * Time.deltaTime);
        if(transform.position == waypoints[currentIndex].transform.position)
        {
            currentIndex++;
        }
       if(currentIndex == waypoints.Length)
        {
            currentIndex = 0;
        }
    }

}
