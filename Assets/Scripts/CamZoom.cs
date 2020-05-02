using UnityEngine;

public class CamZoom : MonoBehaviour
{
	public float zoomSpeed = 250f;
	public float zoomMin = 30f;
	public float zoomMax = 80f;

	private void LateUpdate()
	{
		if (Input.GetMouseButton(2))
		{
			GetComponent<Camera>().fieldOfView -= Input.GetAxis("Mouse Y") * zoomSpeed * 0.01f;
			GetComponent<Camera>().fieldOfView = Mathf.Clamp(GetComponent<Camera>().fieldOfView, zoomMin, zoomMax);
		}
	}
}