using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{
	
	public Transform VrCamera;

	public float ToggleAngleMin = 30.0f;

	public float ToggleAngleMax = 90.0f;

	public float Speed = 10.0f;

	private CharacterController _characterController;

	void Start ()
	{
		_characterController = GetComponent<CharacterController> ();
	}

	private bool IsMoveForwardAngle (Vector3 angle)
	{
		return angle.x > ToggleAngleMin && angle.x < ToggleAngleMax;
	}

	private Vector3 NextStep {
		get {
			Vector3 step = VrCamera.TransformDirection (Vector3.forward);
			step *= Speed * Time.deltaTime;
			step.y = 0;
			return step;
		}

	}

	void Update ()
	{
		if (IsMoveForwardAngle (VrCamera.eulerAngles)) {
			_characterController.Move (NextStep);
		}
	}
}

