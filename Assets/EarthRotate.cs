using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Will rotate earth on y-axis by one degree 60 times in one second
        gameObject.transform.Rotate(new Vector3(0, 1, 0));
    }
}
