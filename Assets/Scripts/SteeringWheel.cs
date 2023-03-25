using UnityEngine;

public class SteeringWheel : MonoBehaviour
{
    [SerializeField] float maxRotate = 900;
	[SerializeField] float minRotate = -900;

	[SerializeField] HingeJoint joint;

    float rot, deltaRot, lastRot;

    void Start()
    {
        lastRot = joint.angle;
    }

    public float GetAxis()
	{
        return maxRotate / rot;
	}

    void FixedUpdate()
    {
        deltaRot = Mathf.DeltaAngle(joint.angle, lastRot);
        lastRot = joint.angle;
        rot += deltaRot;

        if (rot > maxRotate)
		{
            rot = maxRotate;
		}
        else if (rot < minRotate)
		{
            rot = minRotate;
		}
    }
}