using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroScript : MonoBehaviour {
    private Vector2 direction;
    public int velocity = 3;
    public Rigidbody2D rigidbody;
    public int damage;
    public string Enemy;
    public void setDirection (Vector2 direc)
    {
        direction = direc;
    }
	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == Enemy)
        {
            HealthScript health = collision.gameObject.GetComponent<HealthScript>();
            health.Damage(damage);
        }
        else if(collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
    void Update ()
    {
        rigidbody.MovePosition(rigidbody.position + direction * Time.deltaTime * velocity);
    }

}
