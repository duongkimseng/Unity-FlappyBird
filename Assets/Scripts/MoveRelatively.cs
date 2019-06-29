using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRelatively : MonoBehaviour
{
    public MainSpeed mainSpeed = null;

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * mainSpeed.speed;
    }
}
