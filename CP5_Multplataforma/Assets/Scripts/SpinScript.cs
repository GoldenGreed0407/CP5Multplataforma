using UnityEngine;

public class SpinScript : MonoBehaviour
{
    [SerializeField] Vector3 rotationSpeed = new Vector3(0f, 45f, 0f);
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
