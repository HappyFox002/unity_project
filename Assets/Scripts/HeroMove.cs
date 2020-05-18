using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public float moveSpeed = 10f;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            this.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
