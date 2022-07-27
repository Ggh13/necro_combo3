using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class end_game : MonoBehaviour
{
    public GameObject player_win_text;
    public GameObject player_lose_text;
    public GameObject restart_but;
    public bool test = false;
    public bool player_win_test = false;
    // Start is called before the first frame update
    void Start()
    {
        player_win_text.SetActive(false);
        player_lose_text.SetActive(false);
        restart_but.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            end_game_how(player_win_test);
        }
    }
    public void end_game_how(bool player_win)
    {
        if (player_win)
        {
            player_win_text.SetActive(player_win);
            player_lose_text.SetActive(!player_win);
        }
        else
        {
            player_win_text.SetActive(player_win);
            player_lose_text.SetActive(!player_win);
        }
        restart_but.SetActive(true);
    }
    public void load_scene()
    {
        SceneManager.LoadScene("main_scene");
    }
    public void load_scene2()
    {
        SceneManager.LoadScene("studi_scene");
    }
   
}
