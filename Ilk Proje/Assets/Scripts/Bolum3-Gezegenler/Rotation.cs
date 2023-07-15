using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public Vector3 vect;

    void Start()
    {
        vect = new Vector3(0, 0.3f, 0);
    }

    void Update()
    {
        transform.Rotate(vect);
    }
}
