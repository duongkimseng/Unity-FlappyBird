using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{

    public void restartScene()
    {
        SceneManager.LoadScene("Game");
    }
}
