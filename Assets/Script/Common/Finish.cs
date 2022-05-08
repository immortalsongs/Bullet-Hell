using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Animator ani;
    public GameObject EndgameScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        ani.SetTrigger("touch");
        EndgameScene.SetActive(true);
        //Instantiate(EndgameScene, Vector3.zero, Quaternion.identity);
    }
}
