using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public MainSpeed mainSpeed = null;
    public GameObject spawner = null;
    public GameObject bird = null;
    public GameObject restartButton = null;

    private GameObject terrain;

    void Awake()
    {
        terrain = GameObject.Find("Terrain");
    }

    void Start()
    {
        var terrainHeight = terrain.transform.localScale.y;
        var pos = terrain.transform.position;

        pos.x = 0;
        pos.y = -(Screen.height / PixelCamera.pixelToUnit / 2) + (terrainHeight + 8);
        terrain.transform.position = pos;

        restartButton.SetActive(false);
    }

    void Update()
    {
        getHit();
    }

    void getHit()
    {
        if (bird.GetComponent<PlayerControl>().active == false)
        {
            spawner.SetActive(false);
            mainSpeed.speed = 0f;

            restartButton.SetActive(true);
        }
    }

    void restartScene()
    {
        SceneManager.LoadScene("Game");
    }
}
