using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private Quaternion targetModelRotation;
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
        
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Vector2.SignedAngle(Vector2.up, new Vector3( joystickRotate.Horizontal,  joystickRotate.Vertical, 0))));
        
        transform.Translate(horizontal,vertical, 0,Space.World);
    }
    


}
