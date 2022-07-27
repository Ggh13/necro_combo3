using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class casino : MonoBehaviour
{
    public GameObject army;

    public bool[] full = new bool[3];
    public Image[] full_img = new Image[3];

    public GameObject[] full_obj = new GameObject[3];

    public int health = 10;
    public int attack = 2;
    public float speed = 10;

    public GameObject spawner;

    public GameObject base_people;

    public GameObject last_spawned_part;
    public Color player_color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (full[0] && full[1] && full[2])
        {
            float turn_go = base_people.GetComponent<warrior>().turn_go;
            GameObject new_peopl = Instantiate(base_people, spawner.transform);
            new_peopl.transform.SetParent(army.transform);
            new_peopl.transform.position = new_peopl.transform.position - new Vector3(-5f * turn_go, -2, 0);

            for (int i = full_obj.Length - 1; i > -1; i--)
            {
                if(i == full_obj.Length - 1)
                {
                    full_obj[i] = Instantiate(full_obj[i], spawner.transform);
                    full_obj[i].transform.SetParent(new_peopl.transform);
                    warrior new_people_parts = new_peopl.GetComponent<warrior>();
                    new_people_parts.health = health;
                    new_people_parts.speed = speed;
                    new_people_parts.attack = attack;
                    full_obj[i].transform.position = full_obj[i].transform.position - new Vector3(-1, 0, 0);
                    if (base_people.GetComponent<warrior>().turn_go == -1)
                    {
                        full_obj[i].transform.rotation = Quaternion.Euler(full_obj[i].transform.rotation.x, full_obj[i].transform.rotation.y - 180, full_obj[i].transform.rotation.z);
                    }

                }
                else if (i != full_obj.Length - 1)
                {
                    full_obj[i] = Instantiate(full_obj[i], spawner.transform);
                    full_obj[i].transform.SetParent(full_obj[i + 1].transform);
                    warrior new_people_parts = full_obj[i].GetComponent<warrior>();
                    if(base_people.GetComponent<warrior>().turn_go == -1)
                    {
                        full_obj[i].transform.rotation = Quaternion.Euler(full_obj[i].transform.rotation.x, full_obj[i].transform.rotation.y - 180, full_obj[i].transform.rotation.z);
                    }

                    Transform full_now = full_obj[i].GetComponent<for_any_one_part_anim>().down_point.transform;
                    full_obj[i].transform.position = full_obj[i + 1].GetComponent<for_any_one_part_anim>().up_point.transform.position - (new Vector3(full_now.localPosition.x * turn_go, full_now.localPosition.y, full_now.localPosition.z));

                    /*
                    if (full_obj[i+1].name == "croc_legs(Clone)")
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
                   */
                }
                last_spawned_part = full_obj[i];
                full_obj[i].gameObject.GetComponent<SpriteRenderer>().color = player_color;
            }
            for(int i = 0; i < full.Length; i++)
            {
                full[i] = false;
            }

        }
 }
}
