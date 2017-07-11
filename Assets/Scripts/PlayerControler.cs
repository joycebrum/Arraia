using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    private Rigidbody2D rigidbody;
    private bool moving;
    public int velocity;
    private Vector2 direction;
    public GameObject tiro;
    private List<GameObject> tiros = new List<GameObject>();
    private Transform BoardTiros;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        tiros.Clear();
        direction = new Vector2(1, 0);
	}
	
	// Update is called once per frame
	void Update () {
        Moviment();
        if(Input.GetButtonDown("Jump"))
        {
            WeaponScript weapon = GetComponent<WeaponScript>();
            if(weapon!=null)
            {
                weapon.Attack(direction);
            }
        }
    }
 
    private void Moviment()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 moviment = new Vector2(x, y);
        if(moviment!=Vector2.zero)
        {
            moving = true;
            if (x != 0)
            {
                if (x > 0)
                {
                    direction.x = 1;//pega a direção do ultimo movimento
                }
                else
                {
                    direction.x = -1;
                }
            }
            else
            {
                direction.x = 0;
            }
            if(y!= 0)
            {
                if (y > 0)
                {
                    direction.y = 1;
                }
                else
                {
                    direction.y = -1;
                }
            }
            else
            {
                direction.y = 0;
            }
        }
        else
        {
            moving = false;
        }
        rigidbody.MovePosition(rigidbody.position + moviment * Time.deltaTime*velocity);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Peixaria")
        {
            //chama cena de peixaria
        }
        else if(collision.gameObject.tag == "Dungeon")
        {

        }
        else if (collision.gameObject.tag == "Comida")
        {

        }
        else if (collision.gameObject.tag == "Tiro ao alvo")
        {

        }
    }
}
