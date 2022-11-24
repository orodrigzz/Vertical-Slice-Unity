using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpyCharacter : MonoBehaviour
{
    private CharacterController controller;

    private Vector3 finalVelocity = Vector3.zero;
    private float velocityXZ = 5f;
    private float currentspeed = 0f;

    public float speed = 1f;
    public float maxspeed = 2f;

    //Barsalona 
    public float noise = 0f;
    public float maxNoise = 2f;
    public float noiseNow = 0f;
    
    [SerializeField]
    Camera camera;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Vector3 direction = Quaternion.Euler(0f, camera.transform.eulerAngles.y, 0f) * new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        direction.Normalize();

        transform.rotation = Quaternion.Euler(0f, camera.transform.eulerAngles.y, 0f);
        finalVelocity.x = direction.x * velocityXZ;
        finalVelocity.z = direction.z * velocityXZ;

        direction.y = -1f;

        currentspeed = new Vector3(finalVelocity.x, 0.0f, finalVelocity.z).magnitude;
        
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            controller.Move(finalVelocity * maxspeed * Time.deltaTime);
            noise = maxNoise;
        }
        else
        {
            noise = 0f;
        }

        noiseNow = noise;
        if (Input.GetKey(KeyCode.E))
        {
            noise = maxNoise * 2;
        }
        else
        {
            noise = noiseNow;
        }

        controller.Move(finalVelocity * speed * Time.deltaTime);
    }

}