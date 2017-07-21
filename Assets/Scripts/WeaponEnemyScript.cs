using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEnemyScript : MonoBehaviour {

    public Transform ShotPrefab;
    public float cooldown;
    public float shootrate = 0.35f;
    void Start()
    {
        cooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
    }
    public void Attack(Vector2 direction)
    {
        if (cooldown <= 0)
        {
            cooldown = shootrate;
            var shotTransform = Instantiate(ShotPrefab) as Transform;
            shotTransform.position = transform.position;
            TiroScript script = shotTransform.GetComponent<TiroScript>();
            script.setDirection(direction, "Enemy", "Player");

        }
    }
