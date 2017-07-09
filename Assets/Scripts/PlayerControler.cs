using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    private Rigidbody2D rigidbody;
    private bool moving;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Moviment();
    }
 
    private void Moviment()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 moviment = new Vector2(x, y);
        if(moviment!=Vector2.zero)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
        rigidbody.MovePosition(rigidbody.position + moviment * Time.deltaTime);
    }
}
