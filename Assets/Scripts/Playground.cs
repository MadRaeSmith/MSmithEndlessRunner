using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playground : MonoBehaviour
{
    public int health = 0;

    private int maxHeatlth = 10;

    int integer = 5;
    float floatNum = 55.7f;
    public bool isPlayerAlive = true;
    string aliveMessage = "Boy I'm so happy to be alive";
    string deadMessage = "Boy I'm Dead :(";


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(health);
        Debug.Log(maxHeatlth);

        if (health < maxHeatlth)
        {
            isPlayerAlive = false;
        }
         else
        {
            isPlayerAlive = true;
        }

        if (isPlayerAlive == true)
        {
            Debug.Log(aliveMessage);
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
