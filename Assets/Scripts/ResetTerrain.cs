using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTerrain : MonoBehaviour
{
    public SpriteRenderer Renderer;
    public int terrainOffset = 0;

    void Start()
    {
        transform.position += terrainOffset * Renderer.bounds.size.x * Vector3.right;
    }

    void Update()
    {
        if (transform.position.x > -Renderer.bounds.size.x)
        {
            return;
        }
        transform.position += 2 * Renderer.bounds.size.x * Vector3.right;
    }
}
