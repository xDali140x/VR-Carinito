using UnityEngine;

public class SimpleFPSController : MonoBehaviour
{
    public float speed = 5f;
    public float mouseSensitivity = 200f;

    public Transform cameraPivot;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // ===== MOVIMIENTO =====
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        transform.position += move * speed * Time.deltaTime;

        // ===== MOUSE =====
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotación vertical (mirar arriba/abajo)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cameraPivot.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotación horizontal (girar cuerpo)
        transform.Rotate(Vector3.up * mouseX);
    }
}