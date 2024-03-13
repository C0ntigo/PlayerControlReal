using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
    private float propeller = 850;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        propeller = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward, Time.deltaTime * propeller);
    }
}
