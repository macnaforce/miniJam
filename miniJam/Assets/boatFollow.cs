using UnityEngine;

public class boatFollow : MonoBehaviour
{
    public GameObject boat;
    public float hight;
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(boat.transform.position.x, hight, boat.transform.position.z);
        transform.position = newPos;

    }
}
