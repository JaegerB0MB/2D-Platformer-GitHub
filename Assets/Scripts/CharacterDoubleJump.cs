using UnityEngine;
using System.Collections;

public class CharacterDoubleJump : MonoBehaviour {


	Rigidbody2D charRB;
    float hVelocity; // store the directions pressed from -1 to 1.
    [Range(0.01f, 5.0f)]
    Transform charTransform;
	float hFactor;
	public float hScale;
	float vVeolocity;
	public float jumpVal;

	public bool onGround; //on ground check
	public float debounceTime = .25f;
	float jumpStartTime;
	public int jumps;

	Animator animator;

	// Use this for initialization
	void Start () {
		charTransform = gameObject.transform;
		charRB = gameObject.GetComponent<Rigidbody2D> ();
		jumps = 0;
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		print (Input.GetAxis ("Horizontal"));
		hFactor = Input.GetAxis ("Horizontal") * hScale;
	

		if (Input.GetKeyDown (KeyCode.Space)) {
			if(jumps == 1 && ((Time.time - jumpStartTime) > debounceTime)){
				vVeolocity = jumpVal * 1.5f;
				jumps++;
			}

			if (onGround) {
				vVeolocity = jumpVal;
				jumpStartTime = Time.time;
				jumps++;
			}
		} else {
			vVeolocity = 0;
		}

		charRB.velocity += new Vector2 (0, vVeolocity);
        animator.SetFloat("hSpeed", hVelocity);
        charTransform.position = new Vector2 (hFactor + charTransform.position.x, charTransform.position.y);
	}

   void OnTriggerEnter2D(Collider2D coll){
		if (coll.CompareTag ("Ground")) {
			onGround = true;
			jumps = 0;
		}
	}

	void OnTriggerExit2D(Collider2D coll){
		if (coll.CompareTag ("Ground")) {
			onGround = false;
		}
	}
}
