using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionForce : MonoBehaviour
{
    public float radius = 20.0F;
    public float power = 1000F;

    // Start is called before the first frame update
    void OnEnable()
    {
        Explosion();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Explosion()
    {
        Debug.Log("exploded");

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
