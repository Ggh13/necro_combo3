using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour
{
    public Text bio_mass_text;
    public resources resources;
    public casino casino;
    public Sprite defolt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bio_mass_text.text = "Bio_mass: " + resources.biomass.ToString();
    }
    public void casino_but(But_cd cd)
    {
        soldier sold = cd.sold;
        if (cd.cooldown_img.fillAmount == 0 && resources.biomass - cd.cost_of_sold >= 0)
        {
            for (int i = 0; i < casino.full.Length; i++)
            {
                if (casino.full[i] == false)
                {
                    if (i == 1)
                    {

                        // casino.part2_1 = sold.body;
                        // casino.part2_2 = sold.hand_left;
                        // casino.part2_3 = sold.hand_left2;
                        //casino.part2_4 = sold.leg_left;
                        // casino.part2_5 = sold.leg_left2;

                       casino.full_obj[i] = sold.parts[i];
                        

                        casino.full_img[i].GetComponent<Image>().sprite  = sold.body_cas_img;
                        casino.attack = sold.attack;

                        casino.full[i] = true;
                        break;
                    }
                    else if (i == 2)
                    {
                        //casino.part3_1 = sold.leg_left;
                        //casino.part3_2 = sold.leg_left2;

                        
                       casino.full_obj[i] = sold.parts[i];


                        casino.full_img[i].GetComponent<Image>().sprite = sold.head_cas_img;

                        casino.speed = sold.speed;

                        casino.full[i] = true;
                        for (int j = 0; j < casino.full.Length; j++)
                        {
                            casino.full_img[j].GetComponent<Image>().sprite = defolt;
                        }
                            break;
                    }
                    else
                    {
                        casino.full_obj[i] = sold.parts[i];
                        // casino.full_img[i] = sold.body_cas_img;
                        casino.full[i] = true;
                        casino.full_img[i].GetComponent<Image>().sprite = sold.legs_cas_img;
                        casino.health = sold.health;

                        break;
                    }
                    
                }
            }

            resources.biomass -= cd.cost_of_sold;
            cd.start_cor();
            
        }
    }
}
