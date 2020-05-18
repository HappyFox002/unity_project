using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesConstr : MonoBehaviour
{

    private GameObject enemy;
    public GameObject[] enemies = new GameObject[8];
    //
    public float Y = 11f;
    public float Z = 92f;


    void FixedUpdate()
    {
        
        float X = Random.Range(10f, 50f);
        //
        int Rand = Random.Range(0, 7);

        //Creating
        enemy = Instantiate(enemies[Rand], new Vector3(X, Y, Z), Quaternion.identity) as GameObject;
    }

    //Destroy
    private void OnTriggerEnter(Collider enter)
    {
        Destroy(enter.gameObject);
    }

}
