using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject explosion;
    public float damageProiectil;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
            Explozie(collision.contacts[0].point);
         
    }
    public void Explozie(Vector2 collisionpoint)
    {
        Instantiate(explosion, collisionpoint, Quaternion.identity);
        Destroy(gameObject);
    }
}
