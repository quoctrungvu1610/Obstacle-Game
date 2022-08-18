using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float yAngle = 5f;
    [SerializeField] float xAngle = 0f;
    [SerializeField] float zAngle = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Rotate(xAngle,yAngle,zAngle);
    }
}
