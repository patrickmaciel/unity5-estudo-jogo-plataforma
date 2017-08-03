using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
	[Header("Settings")]
	[SerializeField] private float maxSpeed = 10f;
	[SerializeField] private float jumpForce = 100f;
	[SerializeField] private Transform groundCheck;
	[SerializeField] private LayerMask whatIsGround;

	#region Private variables
	bool facingRight = true;
	bool grounded = false;
	float groundRadius = 0.2f;
	#endregion

	#region Animators
	Animator anim;
	#endregion

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && grounded)
		{
			Jump();
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool("Ground", grounded);

		float move = Input.GetAxis("Horizontal");
		anim.SetFloat("speed", Mathf.Abs(move));
		Rigidbody2D r2d = GetComponent<Rigidbody2D>();
		r2d.velocity = new Vector2(move * maxSpeed, r2d.velocity.y);

		if (move > 0 && !facingRight)
		{
			Flip();
		} else if (move < 0 && facingRight) {
			Flip();
		}
	}

	void Jump()
	{
		Debug.Log("VELOCITY => " + GetComponent<Rigidbody2D>().velocity);
		// GetComponent<Rigidbody2D>().AddForce(Vector2.up * 100f, ForceMode2D.Impulse);
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
	}


	void Flip()
	{
		facingRight = !facingRight;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;

	}
}
