using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    public int hp;
	// Use this for initialization
	public void Damage(int value)
    {
        hp -= value;
        if(hp<=0)
        {
            Destroy(gameObject);
        }
    }
}
