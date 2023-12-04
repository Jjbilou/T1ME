using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardMovement : MonoBehaviour
{
    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        movement.Normalize();

        transform.position += movement * Time.deltaTime * speed;
    }
}
