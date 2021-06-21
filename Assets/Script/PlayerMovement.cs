using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;

    public float speed;
    public float jumpSpeed;
    public float horizontal;
    public float slopedownSpeed;

    public float SprintSpeed;
    public bool isSprint = false;
    
    public int energy;
    public int maxEnergy;
    public int energyWithTime;
    public int energyForJump;
    public int energyForSpeedpush;
    public float energyWithTimeInterval;
    public float energyWithSprintTimeInterval;
    float energyTimer=0;
    public bool fillEnergy;


    public AudioSource jumpAudio;


    public bool isDead;


    bool isjump = false;
    

    void Start()
    {
        FindObjectOfType<EnergyBar>().maxEnergy = maxEnergy;
        energy = maxEnergy;
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (energy >0) 
        {
            FindObjectOfType<EnergyBar>().energy = energy;
            readupdate();
            energyUpdateOverTime();
            FillEnergy();
        }
        else if (energy == 0 || energy <0)
        {
            isDead = true;
            playerRB.velocity = new Vector2(0,playerRB.velocity.y);
        }
    }

    void FixedUpdate()
    {
        if (energy > 0)
        {
            move();
            jump();
        }
      
    }

    void FillEnergy()
    {
        if (fillEnergy == true)
        {
            FindObjectOfType<EnergyBar>().fillEnergy=true;
            fillEnergy = false;
            energy = maxEnergy;
        }
    }

    void energyUpdateOverTime()
    {
        if (isSprint == true)
        {
            if (energyTimer < energyWithSprintTimeInterval)
            {
                energyTimer = energyTimer + Time.deltaTime;
            }
            else
            {
                energy = energy - energyForSpeedpush;
                energyTimer = 0;
                FindObjectOfType<EnergyMinusPrefab>().InstantiateFor2();
            }
        }
        if (isSprint == false)
        {
            if (energyTimer < energyWithTimeInterval)
            {
                energyTimer = energyTimer + Time.deltaTime;
            }
            else
            {
                energy = energy - energyWithTime;
                energyTimer = 0;
                FindObjectOfType<EnergyMinusPrefab>().InstantiateFor1();
            }

        }
        



    }
    void readupdate()
    {
        horizontal = 0;
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isjump = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprint = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprint = false;
        }

    }

    void move()
    {
        if (isSprint == true)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x + horizontal * SprintSpeed * Time.deltaTime, playerRB.velocity.y);
        }
        else if (isSprint == false)
        {

            playerRB.velocity = new Vector2(playerRB.velocity.x + horizontal * speed * Time.deltaTime, playerRB.velocity.y);
  

        }
        
       
    }

    void jump()
    {
        if (isjump == true)
        {
            if (FindObjectOfType<CheckGround>().IsGrounded()==true)
            {
                playerRB.velocity = playerRB.velocity+ Vector2.up * jumpSpeed;
                energy = energy - energyForJump;
                jumpAudio.Play();
                FindObjectOfType<EnergyMinusPrefab>().InstantiateFor5();
            }
            isjump = false;
        }
   
    }
}
