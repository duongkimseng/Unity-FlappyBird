using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipControl : MonoBehaviour
{
    public GameObject Upip = null;
    public GameObject Dpip = null;

    public float space = 20f;

    void Start()
    {
        Upip.transform.position = new Vector2(transform.position.x, transform.position.y + space / 2);
        Dpip.transform.position = new Vector2(transform.position.x, transform.position.y - (space / 2));
    }
}
