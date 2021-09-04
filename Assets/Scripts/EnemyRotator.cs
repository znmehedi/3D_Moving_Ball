using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotator : MonoBehaviour
{
    public int rotationSpeed;
    private Collider cd;  
    void Start()
    {
        cd = GetComponent<Collider>();
        cd.isTrigger = true;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 10, 10), rotationSpeed);
    }
}
