using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;

    float mx;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void Update() {
        mx = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(mx * speed, rb.velocity.y);
    }

    private void Jump () {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

}
