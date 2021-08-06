using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public CharacterController CC;
    public float normal_speed=8f;
    public float run_speed = 12f;
    public float jumpspeed_return=0.95f;
    Vector3 tem_move_speed;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * y;
        charactermove(move);
        //if (!Playergravityandjump.is_touchground)
        //{
        //    CC.Move(tem_move_speed*Time.deltaTime);
        //    tem_move_speed *= jumpspeed_return;
        //    Debug.Log(tem_move_speed);

        //}
        //else
        //{
        //    if (Input.GetKey(KeyCode.LeftShift))
        //    {
        //        CC.Move(run_speed * move * Time.deltaTime);
        //        tem_move_speed =move*run_speed;
        //    }
        //    else
        //    {
        //        CC.Move(normal_speed * move* Time.deltaTime);
        //        tem_move_speed = move * normal_speed;
        //    }
        //}
    }
    void charactermove(Vector3 move_)
    {
        if (!Playergravityandjump.is_touchground)
        {
            CC.Move(tem_move_speed*Time.deltaTime);
            tem_move_speed *= jumpspeed_return;

        }
        else
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                CC.Move(run_speed * move_ * Time.deltaTime);
                tem_move_speed =move_*run_speed;
                Debug.Log(1);
            }
            else
            {
                CC.Move(normal_speed * move_ * Time.deltaTime);
                tem_move_speed = move_ * normal_speed;
                Debug.Log(1);
            }
        }
    }

}
