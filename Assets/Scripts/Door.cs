using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] float maxGlassY, minGlassY, glassSpeed = 0.2f;
    [SerializeField] Transform glass;
	[SerializeField] Rigidbody rb;

	float startRotation;

	private void Start()
	{
		startRotation = transform.localRotation.eulerAngles.y;
	}

	public void MoveGlass(float dir)
	{
        glass.Translate(new Vector3(0, glassSpeed * dir * Time.deltaTime, 0));
	}

    public void DoorState(bool open)
	{
		if (Mathf.Abs(startRotation - transform.localRotation.eulerAngles.y) < 10 && !open)
		{
			rb.isKinematic = true;
		}
		else
		{
			rb.isKinematic = false;
		}
	}
}