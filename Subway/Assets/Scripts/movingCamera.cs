using UnityEngine;

public class movingCamera : MonoBehaviour
{
    private Vector3 offset;
    public GameObject target;
    public GameObject camera;
    private float translateSpeed;
    private float rotationSpeed;


    private void FixedUpdate()
    {
        moving();
    }


    private void moving()
    {
        camera.transform.position = new Vector3(target.transform.position.x, target.transform.position.y + 4, target.transform.position.z-7);
    }
}

