using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteccionColisiones : MonoBehaviour
{
    int i = 0;
    AudioSource source;
    bool isPlaying;
    public PlayerController Ctrl;
    public Text Kills;

    void Start()
    {
        
    }

    void Update()
    {
        Ctrl = FindObjectOfType<PlayerController>();
    }

    private void OnCollisionEnter(Collision herido)
    {
        if (herido.gameObject.tag == "Ammo")
        {
            i++;
            if (i == 3)
            {

                Ctrl.kills_i++;
                Debug.Log(Ctrl.kills_i);
                Kills.text = "Kills: " + Ctrl.kills_i;
                Destroy(gameObject);
            }

        }

    }

}