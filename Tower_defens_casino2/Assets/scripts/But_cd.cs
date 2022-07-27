using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class But_cd : MonoBehaviour
{
    public Image cooldown_img;
    public soldier sold;
    public float cd = 4;
    public int cost_of_sold = 10;
    public Text cost_text;
    // Start is called before the first frame update
    void Start()
    {
        cost_text.text = cost_of_sold.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start_cor()
    {
        StartCoroutine(cd_but());
    }
    public IEnumerator cd_but()
    {
        float t = 1;
        while (t > 0)
        {
            t -= 0.01f;
            yield return new WaitForSeconds(cd / 100);
            cooldown_img.fillAmount = t;

        }
        yield break;
    }
}
