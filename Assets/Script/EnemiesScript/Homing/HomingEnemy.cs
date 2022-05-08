using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingEnemy : MonoBehaviour
{
    public GameObject bullet;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(0.3f);
        Instantiate(bullet, transform.position, Quaternion.identity);
        StartCoroutine(Shoot());
    }

}
