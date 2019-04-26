using UnityEngine;

public class gotIt : MonoBehaviour
{
    bool inRange = false;
    bool follow = false;
    public GameObject boat;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        inRange = true;
    }
    private void OnTriggerExit(Collider other)
    {
        inRange = false;
    }
    void Update()
    {
        //Detect when the E arrow key is pressed down
        if ( Input.GetKeyDown(KeyCode.E) && inRange == true)
            follow = true;

        if (follow == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, boat.transform.position, 10f);
        }
    }
}
