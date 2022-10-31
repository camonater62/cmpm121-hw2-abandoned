using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpin : MonoBehaviour
{
    public float speed = 0.0f;

    public GameObject FLWheel, FRWheel, RLWheel, RRWheel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var R = new Vector3(0, 0, 1000 * Time.deltaTime);
        
        FRWheel.transform.Rotate(R);
        RRWheel.transform.Rotate(R);

        FLWheel.transform.Rotate(-R);
        RLWheel.transform.Rotate(-R);
        
    }
}
