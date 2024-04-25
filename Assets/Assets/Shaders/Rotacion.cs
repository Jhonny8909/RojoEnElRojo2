using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float speed;

    public void Update()
    {
        float rot = speed * Time.deltaTime;
        transform.rotation *= Quaternion.Euler(rot, rot, rot);
    }

}
