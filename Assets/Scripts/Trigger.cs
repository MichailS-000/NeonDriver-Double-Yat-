using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Trigger : MonoBehaviour
{
    public UnityEvent onPress;
    public UnityEvent onRelease;

    bool pressed = false;

	private void OnTriggerEnter(Collider other)
	{
		pressed = !pressed;

		if (pressed)
		{
			onPress.Invoke();
		}
		else
		{
			onRelease.Invoke();
		}
	}
}