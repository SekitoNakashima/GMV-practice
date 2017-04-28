using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //  speedを制御する
    public float speed = 15;

    // Use this for initialization
    void FixedUpdate ()
    {
        //  入力をx,yに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        //  speedをかけることによってInspecterで自由に変更できる
        rigidbody.AddForce(x * speed, 0, z * speed);

		
	}
	
}
