using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PlayDanceAnimation : MonoBehaviour {

	public Animation _animation;

	void Start () {
		_animation = GetComponent<Animation> ();
	}
		
	public void TriggerAnimation1()
	{
		_animation.Play ("Dance1");
	}

	public void TriggerAnimation2()
	{
		_animation.Play ("Dance2");
	}

}
