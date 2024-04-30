using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePropeller : MonoBehaviour
{
    //[SerializeField]
    //GameObject planePropeller;

    [SerializeField]
    float propellerRotateSpeed = 20 * 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * propellerRotateSpeed);
    }
}
