using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool is_landing = false;

    IEnumerator BallStart()
    {
        yield return new WaitForSeconds(0f);
        GetComponent<Rigidbody>().velocity = new Vector3(-10.0f, 9.0f, 0.0f);

    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("BallStart");
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject,3.0f);

    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }


}
