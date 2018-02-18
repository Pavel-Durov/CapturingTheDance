using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour {
	
	public Transform vrCamera;

	public float toggleAngleMin = 30.0f;

	public float toggleAngleMax = 90.0f;

	public float speed = 10.0f;

	private CharacterController _characterController;

	void Start () {
		_characterController = GetComponent<CharacterController>();
	}
		
	void Update () {
		float xAngle = vrCamera.eulerAngles.x;

		if (xAngle >= toggleAngleMin && xAngle < toggleAngleMax) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);

			var step = forward * speed;
			_characterController.SimpleMove (step);
		}
	}
}

