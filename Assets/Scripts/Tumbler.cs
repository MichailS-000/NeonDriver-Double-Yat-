using UnityEngine.Events;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Tumbler : MonoBehaviour
{
    public UnityEvent onPress;

	private void OnTriggerStay(Collider other)
	{
		onPress.Invoke();
	}
}