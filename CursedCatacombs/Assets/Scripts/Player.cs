using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private Joystick joystickMove;
    [SerializeField]
    private Joystick joystickRotate;

    [SerializeField]
    private Weapon weapon;

    private bool hasPressed = false;
    private void Start()
    {
        weapon.Init(joystickRotate);
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }
    private void GetInput()
    {
        //movement with the left joystick pad
        float vertical = joystickMove.Vertical * speed * Time.deltaTime;
        float horizontal = joystickMove.Horizontal * speed * Time.deltaTime;

        Vector3 direction = new Vector3(joystickRotate.Horizontal, joystickRotate.Vertical, 0);


        if (direction.magnitude > 0.2f)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, Vector2.SignedAngle(Vector2.up, direction)));
        }
        if (direction.magnitude != 0f && direction.magnitude < 0.2f)
        {
            weapon.startTime = DateTime.Now;
            hasPressed = true;
        }
        else if (hasPressed && direction.magnitude == 0f)
        {
            hasPressed = false;
            int timeSpan = (DateTime.Now - weapon.startTime).Milliseconds;
            if (timeSpan < 500)
            {
                weapon.Attack();
            }
        }
        transform.Translate(horizontal,vertical, 0,Space.World);
    }
}
