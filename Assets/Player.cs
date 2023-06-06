using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float speed;
   public Rigidbody2D rb;

   public int jump = 0;

   void Update() {
         if (Input.GetKeyDown("space") && jump < 2 ) {
            Debug.Log("lompat");
            rb.AddForce(new Vector2(0, 1000f));
            jump++;
        }
   }

   void FixedUpdate(){
    float horizontalMovement = Input.GetAxis("Horizontal");

    Vector2 movement = new Vector2(horizontalMovement * speed, 0.5f);

    rb.AddForce(movement);
   }

   void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Platform")
        {
            jump = 0;
        }
    }
}
