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
           //animator.SetInteger("Speed",1);
        }

        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.eulerAngles += new Vector3(0,-1,0);
        }
    }
}