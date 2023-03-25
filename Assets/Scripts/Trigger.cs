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
		if (!other.CompareTag("XRController"))
			return;
		
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