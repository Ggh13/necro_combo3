using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldier : warrior, IMovable, IGetDamage
{

    public bool canIMove = true;
    public float timer_to_Attack = 0;
    public GameObject blood;
    public GameObject col_check;
    public resources res;
    public float real_speed = 0;
    public string tag_to_damage_people;
    public string tag_to_damage_castle;
    public GameObject sound_die;
    public int r;
    
    // Start is called before the first frame update
    void Start()
    {
      res = GameObject.Find("Canvas").GetComponent<resources>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canIMove)
        {
            Move((0.0001f * speed), 0);
        }
        if(health <= 0)
        {
            //sound_die.SetActive(true);
            if (turn_go == -1)
            {
                res.biomass += 5;
            }
                
            
            Destroy(gameObject);
        }
        if (col_check == null)
        {
            canIMove = true;
        }
    }
    public void Move(float x, float y)
    {
        real_speed = (x * turn_go * speed) * Time.deltaTime;
        transform.position = transform.position + new Vector3(real_speed, y, 0);
    }
    public void GetDamage(int damage)
    {
        health -= damage;
    }

    private void OnTriggerStay(Collider collision)
    {
        col_check = collision.transform.gameObject;
        
            
            //Debug.Log(collision.gameObject.tag.ToString() + "  " + tag_to_damage_people);
            if (collision.gameObject.tag == tag_to_damage_people || collision.gameObject.tag == tag_to_damage_castle)
            {
                canIMove = false;
                if (timer_to_Attack <= Time.time)
                {
                    r = Random.RandomRange(1, 3);
                    Debug.Log(r);
                    if(r == 2)
                    {
                        blood.SetActive(true);
                        //blood.GetComponent<ParticleSystem>().Play();
                    }
                    else if(r != 2)
                    {
                        blood.SetActive(false);
                    }
                    collision.gameObject.GetComponent<IGetDamage>().GetDamage(attack);
                    timer_to_Attack = Time.time + cool_down_Attack;
                }
                
            }
            
        
        
        
    }
    public void OnTriggerExit(Collider collision)
    {
        canIMove = true;
    }



}
