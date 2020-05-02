using UnityEngine;

public class LightOrbit : MonoBehaviour
{
	public Transform target;
	public float distance = 10.0f;

	public float xSpeed = 250.0f;
	public float ySpeed = 120.0f;

	public float yMinLimit = -20f;
	public float yMaxLimit = 80f;

	float x = 0.0f;
	float y = 0.0f;


	private void Start()
	{
		var angles = transform.eulerAngles;
		x = angles.y;
		y = angles.x;

		// Make the rigid body not change rotation
		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;
	}

	private void LateUpdate()
	{
		if (target && Input.GetMouseButton(0))
		{
			x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
			y += Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

			y = ClampAngle(y, yMinLimit, yMaxLimit);

			var rotation = Quaternion.Euler(y, x, 0);

			transform.rotation = rotation;
		}
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		if (angle < -360)
			angle += 360;
		if (angle > 360)
			angle -= 360;
		return Mathf.Clamp(angle, min, max);
	}
}