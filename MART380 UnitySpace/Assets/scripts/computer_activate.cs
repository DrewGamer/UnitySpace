using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class computer_activate : MonoBehaviour {

    public GameObject player;
    public GameObject computerPanel;

    private bool computerUsable = false;

    private void Start()
    {
        if (PlayerPrefs.GetInt("usedComp") == 1)
        {
            player.transform.position = new Vector3(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Z"));
            PlayerPrefs.SetInt("usedComp", 0);
        }
        else
        {
            PlayerPrefs.SetFloat("X", 130);
            PlayerPrefs.SetFloat("Y", 0);
            PlayerPrefs.SetFloat("Z", 150);
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (Input.GetKey("e") && computerUsable)
        {
            PlayerPrefs.SetInt("usedComp", 1);
            PlayerPrefs.SetFloat("X", player.transform.position.x);
            PlayerPrefs.SetFloat("Y", player.transform.position.y);
            PlayerPrefs.SetFloat("Z", player.transform.position.z);
            SceneManager.LoadScene("game_scene");
        }

        if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= 1)
        {
            computerPanel.SetActive(true);
            computerUsable = true;
        }
        else
        {
            computerPanel.SetActive(false);
            computerUsable = false;
        }

    }
    /*
    private void OnMouseEnter()
    {
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= 1)
        {
            computerPanel.SetActive(true);
            computerUsable = true;
        }
    }

    private void OnMouseExit()
    {
        computerPanel.SetActive(false);
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= 1)
        {
            computerPanel.SetActive(false);
            computerUsable = false;
        }
    }
    */
}
