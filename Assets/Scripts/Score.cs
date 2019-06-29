using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public GameObject spawner = null;
    public Text scoreText = null;

    private int score;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Upip")
        {
            score++;
        }
    }
}
