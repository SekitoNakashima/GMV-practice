using System.Collections;
using UnityEngine;

public class item_1 : MonoBehaviour {

    void OnTriggerEnter (Collider hit)
    {

        if (hit.CompareTag ("Player"))
        {
            Destroy(gameObject);
        }
    }
}
