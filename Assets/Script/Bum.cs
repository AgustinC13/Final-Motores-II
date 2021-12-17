using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Applies an explosion force to all nearby rigidbodies
public class Bum : MonoBehaviour
{

    public float radius = 5.0F;
    public float power = 10.0F;


    private void Start()
    {

    }
    void Update()
    {


        if (Input.GetKeyDown("space"))
        { 
            Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
        }
    }
    }
}
