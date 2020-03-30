using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jump_speed = 5.0f;
    private bool is_landing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (is_landing && Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody>().velocity = Vector3.up * jump_speed;
            this.is_landing = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            this.is_landing = true;
        }

    }
}
