using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playergravityandjump : MonoBehaviour
{
    public CharacterController CC;
    public float gravity_num = -9.81f;
    Vector3 vector_gravity;
    public float height = 3f;
    public Transform groundcheck;
    public float grounddistance = 0.4f;
    public LayerMask groundmask;
    public static bool is_touchground;

    // Update is called once per frame
    void Update()
    {
        is_touchground = Physics.CheckSphere(groundcheck.position, grounddistance, groundmask);
        if (is_touchground && vector_gravity.y < 0)
        {
            vector_gravity.y = -2f;
        }
        float jump_vector = Mathf.Pow(height * gravity_num * -2, 0.5f);
        if (Input.GetKeyDown(KeyCode.Space) && is_touchground && vector_gravity.y < 0)
        {
            vector_gravity.y += jump_vector;
        }
        vector_gravity.y += gravity_num * Time.deltaTime;
        CC.Move(vector_gravity * Time.deltaTime);
    }
}
