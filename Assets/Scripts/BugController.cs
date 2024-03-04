using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugController : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] private int bugAmmount;
    private bool isVisible = false;
    public Animator animator;
    void Start()
    {
        gameManager = GameManager.Instance;
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            isVisible = true;
            animator.SetBool("isVisible", true);
        }
        else 
        {
            isVisible = false;
            animator.SetBool("isVisible", false);
        }
    }
    public void Collect()
    {
        gameManager.currentBug += bugAmmount;
        if (gameManager.currentBug > gameManager.maxBug)
        {
            gameManager.currentBug = gameManager.maxBug;
        }

        Destroy(this);
    }
}
