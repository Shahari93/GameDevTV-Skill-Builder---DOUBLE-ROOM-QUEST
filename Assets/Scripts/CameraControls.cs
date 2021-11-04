using UnityEngine;

public class CameraControls : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField] private float zoomSpeed;

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

    }
}
