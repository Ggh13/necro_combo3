using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_casino : MonoBehaviour
{
    public bool[] full = new bool[3];

    public GameObject[] full_obj = new GameObject[3];

    public int health = 100;
    public int attack = 2;
    public float speed = 100;
    public Color enemy_color;
    public GameObject spawner;

    public GameObject base_people;

    public GameObject last_spawned_part;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (full[0] && full[1] && full[2])
        {
            GameObject new_peopl = Instantiate(base_people, spawner.transform);
            new_peopl.transform.position = new_peopl.transform.position - new Vector3(6f, -2, 0);

            warrior new_people_parts = new_peopl.GetComponent<warrior>();

            new_people_parts.health = health;
            new_people_parts.speed = speed;
            new_people_parts.attack = attack;

            for (int i = full_obj.Length - 1; i > -1; i--)
            {

                if (i == full_obj.Length - 1)
                {
                    full_obj[i] = Instantiate(full_obj[i], spawner.transform);
                    full_obj[i].transform.SetParent(new_peopl.transform);
                    full_obj[i].transform.position = full_obj[i].transform.position - new Vector3(-1, 0, 0);


                }
                else if (i != full_obj.Length - 1)
                {
                    full_obj[i] = Instantiate(full_obj[i], spawner.transform);
                    full_obj[i].transform.SetParent(full_obj[i + 1].transform);

                    full_obj[i].GetComponent<for_any_one_part_anim>().who = full_obj[i + 1].name;

                    if (full_obj[i + 1].name == "croc_legs(Clone)")
                    {
                        full_obj[i].GetComponent<for_any_one_part_anim>().Docroc();
                    }
                    else if (full_obj[i + 1].name == "croc_body(Clone)")
                    {
                        full_obj[i].GetComponent<for_any_one_part_anim>().Docroc();
                    }


                    else if (full_obj[i + 1].name == "wolf_body(Clone)")
                    {
                        full_obj[i].GetComponent<for_any_one_part_anim>().Dofolf();

                    }
                    else if (full_obj[i + 1].name == "wolf_legs(Clone)")
                    {
                        full_obj[i].GetComponent<for_any_one_part_anim>().Dofolf();
                    }


                    else if (full_obj[i + 1].name == "bear_body(Clone)")
                    {
                        full_obj[i].GetComponent<for_any_one_part_anim>().Dobear();
                    }
                    else if (full_obj[i + 1].name == "bear_legs(Clone)")
                    {
                        full_obj[i].GetComponent<for_any_one_part_anim>().Dobear();
                    }

                    //Debug.Log(last_spawned_part.name);
                }
                last_spawned_part = full_obj[i];
                full_obj[i].gameObject.GetComponent<SpriteRenderer>().color = enemy_color;
            }
            for (int i = 0; i < full.Length; i++)
            {
                full[i] = false;
            }

        }
    }
}
