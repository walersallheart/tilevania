using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScroll : MonoBehaviour {

	[Tooltip("Game Units Per Second")]
	[SerializeField] float scrollRate = 0.2f;

	// Update is called once per frame
	void Update () {
		transform.Translate(0,scrollRate * Time.deltaTime,0);
	}
}
