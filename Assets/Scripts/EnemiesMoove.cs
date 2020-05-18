using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMoove : MonoBehaviour
{
    public float moveSpeed = 10f;
    void FixedUpdate()
    {
        this.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
