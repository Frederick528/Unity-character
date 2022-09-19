using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Animator ani;
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            ani.SetBool("WALK", true);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                ani.SetTrigger("Running");
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            ani.SetBool("WALK", true);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                ani.SetTrigger("Running");
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            ani.SetBool("WALK", true);
            this.gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                ani.SetTrigger("Running");
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            ani.SetBool("WALK", true);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                ani.SetTrigger("Running");
            }
        }
        else
        {
            ani.SetBool("WALK", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            ani.SetTrigger("Dance");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ani.SetTrigger("Click");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                ani.SetTrigger("RunJump");
            }
            else
            {
                ani.SetTrigger("Jump");
            }
        }

    }
}
