using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    public void gameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
