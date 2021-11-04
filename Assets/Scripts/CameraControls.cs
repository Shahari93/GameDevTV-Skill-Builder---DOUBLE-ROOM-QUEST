using UnityEngine;

public class CameraControls : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField] private float zoomSpeed, rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        ProccesCameraInput();
    }

    private void ProccesCameraInput()
    {
        if (Input.GetKey(KeyCode.E))
        {
            mainCamera.fieldOfView -= zoomSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            mainCamera.fieldOfView += zoomSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.C))
        {
            mainCamera.transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.Z))
        {
            mainCamera.transform.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
        }
    }
}