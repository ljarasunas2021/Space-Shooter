using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float BulletSpeed;

    private void Start()
    {
        transform.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
    }
}
