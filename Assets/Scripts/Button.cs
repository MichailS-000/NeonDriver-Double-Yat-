using UnityEngine.Events;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Button : MonoBehaviour
{
    public UnityEvent onClick;

	private void OnTriggerEnter(Collider other)
	{
		onClick.Invoke();
	}
}