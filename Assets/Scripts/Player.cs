using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Player : MonoBehaviour {
    //=============================================================
    private Animator animator;

    private bool left;
    private bool right;
    private bool up;

    private float turnSpeed = 2f;

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
            right = true;
        }

        if(Input.GetKey(KeyCode.LeftArrow)) {
            left = true;
        }

        if(Input.GetKey(KeyCode.UpArrow)) {
            up = true;
        }

        if(up) {
            ForwardAction();
        }

        if(right) {
            RightAction();
        }

        if(left) {
            LeftAction();
        }
    }

    //=============================================================
    //右ボタン
    public void RightButton () {
        right = true;
    }

    //=============================================================
    //左ボタン
    public void LeftButton () {
        left = true;
    }

    //=============================================================
    //上ボタン
    public void UpButton () {
        up = true;
    }

    //=============================================================
    //右押したときの行動
    private void RightAction () {
        transform.eulerAngles += new Vector3(0,turnSpeed,0);
    }

    //=============================================================
    //左押したときの行動
    private void LeftAction () {
        transform.eulerAngles += new Vector3(0,-turnSpeed,0);
    }

    //=============================================================
    //上押したときの行動
    private void ForwardAction () {
        transform.position += new Vector3(Mathf.Sin(transform.eulerAngles.y * Mathf.Deg2Rad),0,Mathf.Cos(transform.eulerAngles.y * Mathf.Deg2Rad)) * 0.5f;
        animator.SetInteger("Speed",2);
    }

    //=============================================================
    //行動初期化
    public void InitializeAction () {
        up = false;
        left = false;
        right = false;
        animator.SetInteger("Speed",0);
    }
}