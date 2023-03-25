using UnityEngine.Events;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Tumbler : MonoBehaviour
{
    public UnityEvent onPress;
	[SerializeField] LayerMask mask;

	private void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("XRController"))
			onPress.Invoke();
	}
}