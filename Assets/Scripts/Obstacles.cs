using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float liftSpeed;

    // Update is called once per frame
    void Update()
    {   float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.back * Time.deltaTime * speed);
        transform.Translate(Vector3.down * Time.deltaTime * liftSpeed * verticalInput);

    }
}
