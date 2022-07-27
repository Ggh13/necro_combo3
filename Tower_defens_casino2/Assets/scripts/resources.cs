using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resources : MonoBehaviour
{
    public int biomass = 150;
    public int last_bio;
    public float timer_to_give_bio = 0;
    public float cool_down_give_bio = 5;
    public int given_bio = 15;
    public GameObject tpb;
    // Start is called before the first frame update
    void Start()
    {
        last_bio = biomass;
    }

    // Update is called once per frame
    void Update()
    {
        if(last_bio < biomass)
        {
            GameObject tpbG = Instantiate(tpb);
            tpbG.GetComponent<text_plus_bio>().destroy_me = true;
            tpbG.GetComponent<text_plus_bio>().Start_cor(biomass - last_bio);
            last_bio = biomass;
        }
        if(timer_to_give_bio < Time.time)
        {
            biomass += given_bio;
            timer_to_give_bio = Time.time + cool_down_give_bio;
        }
    }
}
