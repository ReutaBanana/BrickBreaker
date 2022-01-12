using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovment : MonoBehaviour
{
    public Vector3 Rotate;
    [SerializeField] int speed=5;
        
    // Update is called once per frame
    void Update()
    {
        Rotate.z = (Input.GetAxis("Horizontal"));
        transform.Rotate(Rotate*speed*Time.deltaTime);
    }
}
