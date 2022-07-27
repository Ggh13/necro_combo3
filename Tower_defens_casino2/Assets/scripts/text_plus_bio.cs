using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class text_plus_bio : MonoBehaviour
{
    public Text text_bio;
    public bool destroy_me = true;
    public GameObject canvas;
    public GameObject start;
    public GameObject finish;
    public Color start_color;
    public Color finish_color;
    // Start is called before the first frame update
    void Start()
    {
        text_bio = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Start_cor(int bio)
    {
        this.transform.SetParent(canvas.transform);
        StartCoroutine(Go_and_noSee_Text(bio));
    }
    public IEnumerator Go_and_noSee_Text(int bio)
    {
        text_bio.text = "+";
        text_bio.text = "+" + bio.ToString();
        float t = 0f;

        while(t <= 1)
        {
            t += 0.55f;
            yield return new WaitForSeconds(0.1f);
            transform.position = Vector3.Lerp(a: start.transform.position, b: finish.transform.position, t);
            text_bio.color = Color.Lerp(a: start_color, b: finish_color, t);

        }
        if (destroy_me)
        {
           Destroy(gameObject);
        }
        yield break;
    }
}
