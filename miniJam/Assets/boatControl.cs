using UnityEngine;

public class boatControl : MonoBehaviour
{
    public float speed = 1f;

    Transform target;

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        transform.position = transform.position + (movement*speed) * Time.deltaTime;

        Vector3 targetDir = movement;
        float step = speed * Time.deltaTime;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);

        transform.rotation = Quaternion.LookRotation(newDir);


    }

}
