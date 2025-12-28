using UnityEngine;

public class LinkButton : MonoBehaviour
{
    public string url;
    public float rotationSpeed = 50f;
    private Camera arCamera;

    void Start()
    {
        // Find the camera automatically
        arCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Checking click at: " + Input.mousePosition);

            // Create ray specifically from the AR Camera
            Ray ray = arCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Debug line: This draws a visible red line in the 'Scene' window so you can see the laser
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 2f);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Raycast HIT: " + hit.transform.name);

                if (hit.transform == transform)
                {
                    Debug.Log("SUCCESS! Opening: " + url);
                    Application.OpenURL(url);
                }
            }
            else
            {
                Debug.Log("Raycast missed. Try clicking exactly in the center of the cube.");
            }
        }
    }
}