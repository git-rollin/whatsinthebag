using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed * -1;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.name == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
