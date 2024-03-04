using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisons : MonoBehaviour
{

    GameManager gameManager;
    public BatController batController;
    private void Start()
    {
        gameManager = GameManager.Instance;

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Obstacle")
        {
            batController.animator.SetBool("isDead", true);
            Debug.Log(batController);
            Debug.Log("Collided with " + other);
            gameObject.SetActive(false);
         
            //TODO connect this to a game Manager and trigger a GameOver();
        }

        if (other.transform.tag == "Bug")
        {
            batController.animator.SetBool("isEating", true);
            other.gameObject.SetActive(false);
            BugController bugController = other.gameObject.GetComponent<BugController>();

            bugController.Collect();

       
        }
    }
}
