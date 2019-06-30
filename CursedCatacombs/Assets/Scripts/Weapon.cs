using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private Animator attackAnim;


    void start()
    {
        attackAnim = GetComponent<Animator>();
    }

    private void Attack()
    {
        if (true)
        {
            attackAnim.SetBool("isAttacking", true);
        }
        else
        {
            attackAnim.SetBool("isAttacking", false);
        }
    }
}
