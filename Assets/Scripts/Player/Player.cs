using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;

    private Vector3 finalVelocity = Vector3.zero;
    private float velocityXZ = 5f;
    public float currentspeed = 0f;

    [SerializeField]
    Camera camera;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Quaternion.Euler(0f, camera.transform.eulerAngles.y, 0f) * new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        direction.Normalize();

        transform.rotation = Quaternion.Euler(0f, camera.transform.eulerAngles.y, 0f);
        finalVelocity.x = direction.x * velocityXZ;
        finalVelocity.z = direction.z * velocityXZ;

        direction.y = -1f;

        currentspeed = new Vector3(finalVelocity.x, 0.0f, finalVelocity.z).magnitude;

        controller.Move(finalVelocity * Time.deltaTime);
    }
}