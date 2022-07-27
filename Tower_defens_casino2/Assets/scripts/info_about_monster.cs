using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class info_about_monster : MonoBehaviour
{
    public But_cd your_but;
    public Text info_text_name;
    public Text info_text_health;
    public Text info_text_attack;
    public Text info_text_speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void show_on_info()
    {
        info_text_name.text = your_but.sold.name_of_animal.ToString();
        info_text_health.text = "Head`s health: " + your_but.sold.health.ToString();
        info_text_attack.text = "Body`s attack: " + your_but.sold.attack.ToString();
        info_text_speed.text = "Speed`s speed: " + your_but.sold.speed.ToString();
    }
}
