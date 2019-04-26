using UnityEngine;

public class cameraZoom : MonoBehaviour
{
    public GameObject vision;
    public float height;
    public float normalHeight;
    private void OnTriggerEnter(Collider other)
    {
        vision.transform.position = new Vector3(vision.transform.position.x, height, vision.transform.position.z);
    }

    private void OnTriggerExit(Collider other)
    {
            vision.transform.position = new Vector3(vision.transform.position.x, normalHeight, vision.transform.position.z);
    }


}
