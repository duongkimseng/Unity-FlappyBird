using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float jumpSpeed = 240f;
    public bool active = true;

    private Rigidbody2D body2d;

    void Start()
    {
        body2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(active)
        {
            if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) /*|| Input.anyKeyDown*/)
            {
                body2d.velocity = new Vector2(0, jumpSpeed);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Pip") || col.gameObject.tag.Equals("Ground"))
        {
            active = false;
        }
    }
}
