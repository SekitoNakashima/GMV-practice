using System.Collections;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; //ターゲットへの参照
    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {

        offset = GetComponent<Transform>().position - target.position;
		
	}

    void Update ()
    {
        GetComponent<Transform>().position = target.position + offset;

    }

}
