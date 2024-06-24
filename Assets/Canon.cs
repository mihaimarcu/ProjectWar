using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public float projectileSpeed;
    public float projectilesPerSecond;
    public GameObject projectileSpawnPlace;
    public GameObject projectile;
    public Transform body;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AutoShoot(projectileSpeed));
    }

    private IEnumerator AutoShoot(float power)
    {
        while (true)
        {
            var newProjectile = Instantiate(projectile, projectileSpawnPlace.transform.position, body.rotation);
            newProjectile.GetComponent<Rigidbody2D>().AddForce(body.right * power);

            yield return new WaitForSeconds(1 / projectilesPerSecond);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && (body.eulerAngles.z < 30 || body.eulerAngles.z > 325))
        {
            body.RotateAround(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && (body.eulerAngles.z > 340 || body.eulerAngles.z < 45))
        {
            body.RotateAround(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
    }
}
