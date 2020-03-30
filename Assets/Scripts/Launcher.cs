using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject ballPrefab;
    //public Ball ballcs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(ballPrefab);
                //ballPrefab.GetComponent<Rigidbody>().velocity = new Vector3(-10.0f, 9.0f, 0.0f);
                //ballcs.is_landing = false;

            }
        }
        catch (System.Exception)
        {
        	//miss obj
        }
        
    }




}
