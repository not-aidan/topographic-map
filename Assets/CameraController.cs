using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;

        transform.position += new Vector3(horizontal, 0, vertical);

    }
}
