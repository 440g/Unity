using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HW01_CollisionDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print($"{gameObject.name} has detected TriggerEnter: {other.name}");

        if (gameObject.name == "DestroyCube")
        {
            Destroy(gameObject);
        }
    }
}
