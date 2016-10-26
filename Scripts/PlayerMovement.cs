using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float movementSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float hMoveInput = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
		float vMoveInput = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		transform.position += new Vector3 (hMoveInput, vMoveInput, 0);
	}
}
