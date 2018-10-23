using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characteranimation : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isrunning", true);
        } else {
            anim.SetBool("isrunning", false);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetTrigger("jump");
        }
        }
	}
