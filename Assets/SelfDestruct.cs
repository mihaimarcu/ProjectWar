using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float destructionTime;
    private IEnumerator DestructionRoutine(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestructionRoutine(destructionTime));
    }
}
