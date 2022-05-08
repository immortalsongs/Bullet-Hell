using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareEnemy : MonoBehaviour
{
    public GameObject bullet;

    public float livingTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());

    }

    // Update is called once per frame
    void Update()
    {
        if (livingTime <= 0) Destroy(gameObject);
        livingTime -= Time.deltaTime;
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(0.7f);
        Instantiate(bullet, transform.position, Quaternion.identity);
        StartCoroutine(Shoot());
    }
}
