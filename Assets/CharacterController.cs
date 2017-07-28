using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
	[Header("Settings")]
	[SerializeField] private float maxSpeed = 10f;
	
	#region Private variables
	private bool facingRight = true;
	#endregion

	#region Animators
	Animator anim;
	#endregion

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
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

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;

	}
}
