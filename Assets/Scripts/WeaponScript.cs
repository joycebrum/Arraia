using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour {

    public Transform ShotPrefab;
    public float cooldown;
    public float shootrate = 0.25f;
	void Start ()
    {
        cooldown = 0; 
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
	}
    public void Attack(Vector2 direction)
    {
        if(cooldown<=0)
        {
            cooldown = shootrate;
            var shotTransform = Instantiate(ShotPrefab) as Transform;
            shotTransform.position = transform.position;
            TiroScript script = shotTransform.GetComponent<TiroScript>();
            script.setDirection(direction);
        }
    }
}
