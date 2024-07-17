using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
    public float walkingSpeed;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteAnimator>().PlayAnimation("Walk");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - walkingSpeed*Time.deltaTime, transform.position.y, transform.position.z);
    }
}
