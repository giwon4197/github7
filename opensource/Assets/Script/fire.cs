using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject ball;

    
    void Start()
    {
        InvokeRepeating("shoot", 0.5f,2f);
    }

    void shoot()
    {
        float speed = 1500 * Time.deltaTime;

        GameObject bullet = Instantiate(ball, transform.position, transform.rotation);
        Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
        rigid.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
    }
}
