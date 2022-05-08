using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiningEnemy : MonoBehaviour
{
    public float rotateSpeed;
    public float livingTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(livingTime>=5)
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        else transform.Rotate(-Vector3.forward * rotateSpeed * Time.deltaTime);

        if (livingTime <= 0) Destroy(gameObject);
        livingTime -= Time.deltaTime;
    }
}
