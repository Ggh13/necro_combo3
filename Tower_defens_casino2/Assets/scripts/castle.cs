using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castle : MonoBehaviour, IGetDamage
{
    public float health = 1000;
    public GameObject hp_bar;
    public bool are_u_player_castle = false;
    public end_game eg;

    public void GetDamage(int damage)
    {
        health -= damage;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hp_bar.transform.localScale = new Vector3(health / 50, hp_bar.transform.localScale.y, hp_bar.transform.localScale.z);
        if(health < 0)
        {
            health = 0;
            eg.end_game_how(!are_u_player_castle);
        }
    }
}
