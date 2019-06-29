using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    public float offset = 32f;

    void Update()
    {
        if(transform.position.x > - (Screen.width / PixelCamera.pixelToUnit / 2 + offset))
        {
            return;
        }

        Destroy(gameObject);
    }
}
