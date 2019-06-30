using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Weapon : MonoBehaviour
{
    private Joystick joystickRotate;
    [SerializeField]
    private Animator attackAnim;
    public DateTime startTime;
    private DateTime testTime;
    void Start()
    {
        attackAnim = GetComponent<Animator>();
        testTime = DateTime.Now;
    }
    public void Init(Joystick joystick)
    {
        joystickRotate = joystick;
    }
    void Update()
    {
        //if ((DateTime.Now - testTime).Seconds > 10)
        //{
        //    Attack();
        //}
    }
    public bool Attack()
    {
        attackAnim.SetBool("isAttacking", true);
        Debug.Log("hvad så med dette?" + attackAnim.GetBool("isAttacking"));
        return true;
        
        //else
        //{
        //    attackAnim.SetBool("isAttacking", false);
        //    return false;
        //}
    }
}
