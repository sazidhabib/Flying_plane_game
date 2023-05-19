using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public GameObject propeller;
    private float moveSpeed = 300.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.Euler(new Vector3(0, 0, 10) * moveSpeed * Time.deltaTime);
        propeller.transform.Rotate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
