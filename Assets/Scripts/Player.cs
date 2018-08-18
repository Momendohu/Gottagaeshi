using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Player : MonoBehaviour {
    //=============================================================
    private Animator animator;

    //=============================================================
    private void Init () {
        CRef();
    }

    //=============================================================
    private void CRef () {
        animator = GetComponent<Animator>();
    }

    //=============================================================
    private void Awake () {
        Init();
    }

    private void Start () {

    }

    private void Update () {
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.eulerAngles += new Vector3(0,1,0);
        }

        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.eulerAngles += new Vector3(0,-1,0);
        }

        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(Mathf.Sin(transform.eulerAngles.y*Mathf.Deg2Rad),0,Mathf.Cos(transform.eulerAngles.y * Mathf.Deg2Rad))*0.5f;
            animator.SetInteger("Speed",2);
        } else {
            animator.SetInteger("Speed",0);
        }
    }
}