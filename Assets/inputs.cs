using UnityEngine;
using System.Collections;

public class inputs : MonoBehaviour {

	float speed = 3;

	void Update () {
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
	}
}
