using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion1 : MonoBehaviour
{
    public float speed;

    public void Update()
    {
        float rot = speed * Time.deltaTime;
        transform.rotation *= Quaternion.Euler(0, rot, 0);
    }

}
