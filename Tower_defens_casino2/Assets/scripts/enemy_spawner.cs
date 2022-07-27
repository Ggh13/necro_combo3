using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public GameObject[] prefab = new GameObject[3];
    public Color change_color;
    public float timer = 0;
    public int min_time_spawn = 1;
    public int max_time_spawn = 8;

    public casino ec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= Time.time)
        {
            timer = Time.time + Random.RandomRange(min_time_spawn, max_time_spawn);
            soldier sold = (prefab[Random.RandomRange(0, prefab.Length)].GetComponent<soldier>());
                for (int i = 0; i < ec.full.Length; i++)
                {
                    if (ec.full[i] == false)
                    {
                        if (i == 1)
                        {
                           
                                ec.full_obj[i] = sold.parts[i];
                        
                            ec.attack = sold.attack;

                            ec.full[i] = true;
                            break;
                        }
                        else if (i == 2)
                        {
                            ec.full_obj[i] = sold.parts[i];
                            ec.speed = sold.speed;

                            ec.full[i] = true;
                            break;
                        }
                        else
                        {
                            ec.full_obj[i] = sold.parts[i];
                            ec.full[i] = true;

                            ec.health = sold.health;

                            break;
                        }
                    }
                }
            }
        }
    }
