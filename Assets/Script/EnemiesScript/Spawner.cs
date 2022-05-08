using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject HomingEnemy;
    public GameObject SquarEnemy;
    public GameObject SpiningEnemy;
    public GameObject horiSquareEnemy;

    public GameManager gm;

    public GameObject player;
    PlayerBeha[] pl;
    //public GameObject finish;

    //public float w8Time;
    public float GameTime;
    public int count;

    //time
    public int first, second, third, forth, fifth, sixth, seventh, eighth, ninth;

    // Start is called before the first frame update
    void Start()
    {
        GameTime = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("player");
        pl = player.GetComponents<PlayerBeha>();
        if (pl[0].hp > 0)
        {
            //w8Time -= Time.deltaTime;
            GameTime = gm.gameTime;
            if (Mathf.RoundToInt(GameTime) == first && count == 0)
            {
                transform.position = new Vector3(-8, 4, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);


                transform.position = new Vector3(0, 4, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(-8, -4, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(0, -4, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(8, -4, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(8, 4, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                count++;
            }
            if (Mathf.RoundToInt(GameTime) == second && count == 1)
            {
                transform.position = new Vector3(-7, 0, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(-3.5f, 2, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(0, 4, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(3.5f, 2, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                //transform.position = new Vector3(0, -4, 0);
                //Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                //transform.position = new Vector3(-3.5f, -2, 0);
                //Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(7, 0, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(3.5f, -2, 0);
                Instantiate(HomingEnemy, transform.position, Quaternion.identity);

                count++;
            }

            if (Mathf.RoundToInt(GameTime) == third && count == 2)
            {
                transform.position = new Vector3(-7, 4, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(-5, 3, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(-3, 2, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(-1, 1, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                //transform.position = new Vector3(0, 4, 0);
                //Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(7, 4, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(5, 3, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(3, 2, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(1, 1, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                count++;
            }

            if (Mathf.RoundToInt(GameTime) == forth && count == 3)
            {
                transform.position = new Vector3(-8, -4, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(-6, -3, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(-4, -2, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(-2, -1, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(0, 0, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(8, 1, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(6, 2, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(4, 3, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                transform.position = new Vector3(2, 4, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                count++;
            }

            if (Mathf.RoundToInt(GameTime) == fifth && count == 4)
            {
                transform.position = new Vector3(0, 3, 0);
                Instantiate(SpiningEnemy, transform.position, Quaternion.identity);

                count++;
            }

            if (Mathf.RoundToInt(GameTime) == sixth && count == 5)
            {
                transform.position = new Vector3(0, -3, 0);
                Instantiate(SpiningEnemy, transform.position, Quaternion.identity);
                transform.position = new Vector3(-8, 4, 0); Instantiate(SquarEnemy, transform.position, Quaternion.identity);
                transform.position = new Vector3(8, 4, 0); Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                count++;
            }

            if (Mathf.RoundToInt(GameTime) == seventh && count == 6)
            {
                transform.position = new Vector3(-4, 4, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);
                transform.position = new Vector3(4, 4, 0);
                Instantiate(SquarEnemy, transform.position, Quaternion.identity);
                count++;
            }

            if (Mathf.RoundToInt(GameTime) == eighth && count == 7)
            {
                transform.position = new Vector3(-7, 0, 0);
                Instantiate(SpiningEnemy, transform.position, Quaternion.identity);
                transform.position = new Vector3(7, 4, 0);
                Instantiate(SpiningEnemy, transform.position, Quaternion.identity);

                //transform.position = new Vector3(7, -2, 0);
                //Instantiate(horiSquareEnemy, transform.position, Quaternion.identity);
                //transform.position = new Vector3(7, 0, 0);
                //Instantiate(horiSquareEnemy, transform.position, Quaternion.identity);
                //transform.position = new Vector3(7, , 0);
                //Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                count++;
            }

            if (Mathf.RoundToInt(GameTime) == ninth && count == 8)
            {
                transform.position = new Vector3(7, 0, 0);
                Instantiate(SpiningEnemy, transform.position, Quaternion.identity);
                transform.position = new Vector3(-7, 4, 0);
                Instantiate(SpiningEnemy, transform.position, Quaternion.identity);

                //transform.position = new Vector3(7, -2, 0);
                //Instantiate(horiSquareEnemy, transform.position, Quaternion.identity);
                transform.position = new Vector3(-7, 3, 0);
                Instantiate(horiSquareEnemy, transform.position, Quaternion.identity);
                transform.position = new Vector3(7, -3, 0);
                Instantiate(horiSquareEnemy, transform.position, Quaternion.identity);
                //transform.position = new Vector3(7, , 0);
                //Instantiate(SquarEnemy, transform.position, Quaternion.identity);

                count++;
            }

            //if (Mathf.RoundToInt(GameTime) == 65 && count == 9)
            //{
            //    transform.position = new Vector3(7, 0, 0);
            //    Instantiate(finish, transform.position, Quaternion.identity);
            //    count++;
            //}

        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
    }    
}
