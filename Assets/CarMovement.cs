using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        basePos = transform.localPosition;
    }

    private Vector3 basePos;
    private float time;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        float xpos = 5 * Mathf.Sin(time / 3.0f + 5);
        float zpos = 5 * Mathf.Sin(time / 1.0f);

        Vector3 add = new Vector3(xpos, 0, zpos);

        transform.localPosition = add + basePos;
    }
}
