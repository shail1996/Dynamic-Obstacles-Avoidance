using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicObstacles : MonoBehaviour
{
    public Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position -= transform.forward * Time.deltaTime * 2;
        transform.position = Vector3.MoveTowards(transform.position, destination.position, Time.deltaTime * 2);
    }
}
