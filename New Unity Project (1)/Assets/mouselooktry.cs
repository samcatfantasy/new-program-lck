using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselooktry : MonoBehaviour
{
    public float mousesensitivity = 100f;
    public Transform playerBody;
    float xrotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*mousesensitivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")* mousesensitivity * Time.deltaTime;
        xrotation -= mouseY;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xrotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseY);

    }
}
