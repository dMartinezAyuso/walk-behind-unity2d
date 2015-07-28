using UnityEngine;
using System.Collections;

public class WalkBehind : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			Debug.Log ("entra");
			other.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "top";
			this.GetComponent<SpriteRenderer>().sortingLayerName = "down";
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "down";
			this.GetComponent<SpriteRenderer>().sortingLayerName = "top";
		}
	}
}
