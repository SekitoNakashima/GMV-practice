using System.Collections;
using UnityEngine;

public class gamecontroller : MonoBehaviour {

    public UnityEngine.UI.Text scoreLabel;
    public void Update ()
    {
        int count = GameObject.FindGameObjectsWithTag ("Item").Length;
        scoreLabel.text = count.ToString ();
    }
}
