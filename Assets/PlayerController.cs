using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text Timer;
    float time;
    bool hasJump;
    Rigidbody rb;
    public float MSpeed;
    public float Rspeed;
    public Text EstadoDeJuego;
    bool IsAlive = true;
    public int GameTime;
    public int AmountEnemies;
    
    public int kills_i;

    // Start is called before the first frame update
    void Start()
    {
        hasJump = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsAlive)
        {
            time = Time.time * 100;
            time = Mathf.Floor(time) / 100;

            Timer.text = "" + time.ToString();
        }
        


        if (time > GameTime)
        {
            IsAlive = false;
            Timer.text = Timer.text;
            EstadoDeJuego.text = "Perdiste!";
        }

        if(kills_i == AmountEnemies)
        {
            IsAlive = false;
            Timer.text = Timer.text;
            EstadoDeJuego.text = "Ganaste!";
        }
        
        
        //Movimiento y rotación del jugador teclas W-S-D-A
        if (Input.GetKey(KeyCode.W) && IsAlive)
        {
            transform.Translate(0, 0, MSpeed);
        }

        if (Input.GetKey(KeyCode.S) && IsAlive)
        {
            transform.Translate(0, 0, -MSpeed);
        }

        if (Input.GetKey(KeyCode.D) && IsAlive)
        {
            transform.Rotate(0, Rspeed, 0);
        }

        if (Input.GetKey(KeyCode.A) && IsAlive)
        {
            transform.Rotate(0, -Rspeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && hasJump && IsAlive)
        {
            rb.AddForce(Vector3.up * 5 , ForceMode.Impulse);
            hasJump = false;
        }

        //Movimiento y rotación del jugador teclas Flechitas

        if (Input.GetKey(KeyCode.UpArrow) && IsAlive)
        {
            transform.Translate(0, 0, MSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow) && IsAlive)
        {
            transform.Translate(0, 0, -MSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow) && IsAlive)
        {
            transform.Rotate(0, Rspeed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && IsAlive)
        {
            transform.Rotate(0, -Rspeed, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            hasJump = true;
        }
    }
}