using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerAnimation anim;

    [SerializeField]
    private float flapForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<PlayerAnimation>();
    }

    void Update()
    {
		if (rb.velocity.y < 0)
            anim.FallAnimation();

		if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * flapForce, ForceMode2D.Impulse);
            anim.FlapAnimation();
        }
    }
}
