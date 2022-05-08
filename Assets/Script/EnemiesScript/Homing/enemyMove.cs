using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public float speed=10;
    private Vector3 target;

    public float livingTime;

    public Animation ani;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(true);
        //target = new Vector3(Random.Range(-10, 11), Random.Range(-4, 5), 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (livingTime <= 0) Destroy(gameObject);
        livingTime -= Time.deltaTime;

        //Vector3 dir = (target - transform.position).normalized;
        //if ((transform.position - target).magnitude<1)
        //{
        //    target = new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0f);
        //}
        //else transform.position +=  dir* speed * Time.deltaTime;
    }
}
