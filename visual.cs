using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visual : MonoBehaviour
{
	private float mouseSensibility = 100f;
	public Transform playerBody;
	private float mouseX,mouseY;
	private float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensibility;
        mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensibility;
        xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
