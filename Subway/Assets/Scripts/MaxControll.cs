using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxControll : MonoBehaviour
{
    public GameObject Max;
    [SerializeField] private LayerMask ground;
    [SerializeField] private float jumpHeight = 2f;
    [SerializeField] private float currentSpeed = 0.3f;
    [SerializeField] [Range(0f, 4f)] float lerpTime;

    public Animation animL;
    public Animation animR;

    private float gravity = -50f;


    private const float increasingSpeed = 0.001F;
    private float currentTrack = 0f;
    public Vector3 jump;
    public Vector3 trackL = new Vector3(-5, 0, 0);
    public Vector3 trackR = new Vector3(5, 0, 0);
    private Vector3 velocity;

    public Rigidbody rb;

    public float jumpForce = 2.0f;

    public bool isOnGround;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
        private void Update()
        {

           float currentPosX = transform.position.x;

        if (Input.GetKeyDown(KeyCode.A) == true && currentPosX > -5f)
        {
            transform.position += new Vector3(-5f, 0, 0);
        }

        else if (Input.GetKeyDown(KeyCode.D) == true && currentPosX < 5f)
        {
            transform.position += new Vector3(5f, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A) == true && currentPosX > -5f && currentPosX < 4.9f) ;

        else if (Input.GetKeyDown(KeyCode.D) == true && currentPosX <= 5f && currentPosX > 4.9f) ;

    }
    void FixedUpdate()
    {
        

        velocity.y += gravity * Time.deltaTime / 22;

        //.Lerp na plynulé přesunutí mezi kolejemi
        /*(Input.GetButtonDown("Jump"))
        {
            Max.GetComponent<Rigidbody>().AddForce(Physics.gravity * (gravity - 1) * Max.GetComponent<Rigidbody>().mass);
        }
        */
        bool keyL = Input.GetKeyDown(KeyCode.A);
        bool keyR = Input.GetKeyDown(KeyCode.D);
        
        float currentPosY = transform.position.y;
        float currentPosZ = transform.position.z;

        Max.transform.position += new Vector3(0, 0, currentSpeed + increasingSpeed * currentSpeed * Time.deltaTime);
      }


    
}