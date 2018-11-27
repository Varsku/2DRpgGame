using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour {

    public Rigidbody2D rB;
    public float moveSpeed;
    public Animator moveAnim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      rB.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;
        moveAnim.SetFloat("MoveX", rB.velocity.x);
        moveAnim.SetFloat("MoveY", rB.velocity.y);

        if(Input.GetAxisRaw("Horizontal") ==  1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1) {
            moveAnim.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
            moveAnim.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
        } 
	}
}
