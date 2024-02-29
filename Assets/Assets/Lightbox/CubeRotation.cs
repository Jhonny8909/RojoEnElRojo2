using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    private GameObject cube;

    void Start()
    {
        cube = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Rotate(0f, 0.5f, 0f, Space.Self);
    }
}
