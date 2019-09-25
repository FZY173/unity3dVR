using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class person : MonoBehaviour
{
    Animator personAnimator;
    void Start()
    {
        personAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            personAnimator.SetTrigger("jump");
        }
        if (Input.GetKey(KeyCode.S))
        {
            personAnimator.SetBool("walk",false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            personAnimator.SetBool("walk", true);
        }
    }
}
