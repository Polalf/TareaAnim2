using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform PointA;
    public Transform PointB;

   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            transform.position = PointA.position;
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            transform.position = PointB.position;
        }
    }
}
