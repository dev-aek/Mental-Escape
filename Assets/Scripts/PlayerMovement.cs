using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    private void Start()
    {
        PlayerPrefs.SetInt("brush", 0);
    }
    void Update()
    {
        //float x = Input.GetAxis("Horizontal") * Time.deltaTime * 3f;
        //transform.Translate(x, 0, 0);
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * 3f, rb.velocity.y);

        if(moveInput == 0)
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isRunning", false);
        }
        else
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isIdle", false);
        }
        if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }else if(moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
