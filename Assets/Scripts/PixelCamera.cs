using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelCamera : MonoBehaviour
{
    public static float pixelToUnit = 0f;
    public static float scale = 0f;

    public Vector2 nativeResolution = new Vector2(480, 320);

    void Awake()
    {
        var camera = GetComponent<Camera>();

        if (camera.orthographic)
        {
            scale = Screen.height / nativeResolution.y;
            pixelToUnit = scale * 1f;
            camera.orthographicSize = (Screen.height / 2f) / pixelToUnit;
        }
    }
}
