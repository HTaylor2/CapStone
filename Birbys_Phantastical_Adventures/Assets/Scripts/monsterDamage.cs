using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterDamage : MonoBehaviour
{
    public int damage;
    public Health playerHealth;
    // Start is called before the first frame update
    
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            playerHealth.Damage(damage);
        }
    }
}