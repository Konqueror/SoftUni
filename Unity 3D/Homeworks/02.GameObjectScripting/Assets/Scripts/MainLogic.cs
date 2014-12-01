using UnityEngine;
using System.Collections;

public class MainLogic : MonoBehaviour
{

    GameObject[] enemies;
    GameObject player;
    float distance;
    GameObject rocket;
    float[] delays;

    // Use this for initialization
    void Start()
    {
        Screen.showCursor = false;

        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        delays = new float[enemies.Length];

        for (int i = 0; i < delays.Length; i++)
        {
            delays[i] = 0;
        }

        player = GameObject.Find("Player");
        rocket = (GameObject) Resources.Load("Rocket");
    }

    // Update is called once per frame
    void Update()
    {
        for (int count = 0; count < delays.Length; count++)
        {
            delays[count] -= Time.deltaTime;
        }


        for (int count = 0; count < enemies.Length; count++)
        {
            enemies[count].transform.LookAt(player.transform.position);
            enemies[count].transform.eulerAngles = new Vector3(0f, enemies[count].transform.eulerAngles.y - 180f, 0f);

            distance = Vector3.Distance(enemies[count].transform.position, player.transform.position);

            if (distance <= 30 && delays[count] <= 0) 
            {
                Instantiate(rocket);
                rocket.transform.position = new Vector3(enemies[count].transform.position.x,
                    enemies[count].transform.position.y + 1.5f, enemies[count].transform.position.z);
                rocket.transform.LookAt(player.transform.position);

                delays[count] = 1;
            }
        }
            
    }
}
