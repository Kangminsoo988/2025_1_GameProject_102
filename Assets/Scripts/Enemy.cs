using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 100;
    public float Timer = 1.0f;
    public int Attackpoint = 50;

    void Start()
    {
        Health = 100;    
    }


    void Update()
    {
        CharacterHealthUp();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Health -= Attackpoint;
        }
        CheckDeath();

    }

    void CharacterHealthUp()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0)
        {
            Timer = 1;
            Health += 10;
        }
    }
     public void CharacterHit(int Damage)
     {
        Health -= Damage;
     }

     void CheckDeath()
     {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
     }


    
}
