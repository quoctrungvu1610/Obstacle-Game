using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    MeshRenderer renderer;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rb.useGravity = false;
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timeToWait)
        {
           rb.useGravity = true;
           renderer.enabled = true;
        }
    }
}
