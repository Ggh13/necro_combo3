using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class warrior : MonoBehaviour
{
    public string name_of_animal;
    [Header ("Stats")]
    public int attack = 2;
    public int health = 10;
    [Range(50, 400)]
    public float speed = 10;
    public float cool_down_Attack = 3;

    [Header("Our_or_not")]

    public float turn_go = 1;

    public GameObject[] parts = new GameObject[6];

    [Header("sprites")]
    public Sprite head_cas_img;
    public Sprite body_cas_img;
    public Sprite legs_cas_img;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
