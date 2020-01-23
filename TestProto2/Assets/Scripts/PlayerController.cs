using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

    transform.position = transform.position + new Vector3 (horizontalInput * speed * Time.deltaTime, 0, verticalInput * speed * Time.deltaTime);

    Debug.Log (transform.position);

    if (Input.GetKeyDown(KeyCode.E))
    {
        // sphere gizmo interact w quad to open chest w colliders
        // Debug.Log ($"<b> Chest Open </b>");
    }

    }

    // void Awake()
    // {
    //     transform.position = new Vector3(0.0f, 0.0f, 0.0f);

    //     GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    //     Camera.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);

    //     target = cylinder.transform;
    //     target.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);
    //     target.transform.position = new Vector3(0.8f, 0.0f, 0.8f);

    //     Camera.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);
    //     Camera.main.transform.localEulerAngles = new Vector3(15.0f, -20.0f, -0.5f);

    //     // Create and position the floor.
    //     GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
    //     floor.transform.position = new Vector3(0.0f, -1.0f, 0.0f);
    // }
    

    // void Update()
    // {
    //     float step = speed * Time.deltaTime;
    //     transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    // }
}