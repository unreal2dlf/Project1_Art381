using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Collisions : MonoBehaviour
{

    public TMP_Text countText;
    public TMP_Text healthText;
    public TMP_Text winText;
    public TMP_Text loseText;
    public TMP_Text runeText;
//count=counting books collected

  //  public GameObject button;


    private int count;
    private int health;
    private int rune;

    void Start()
    {
        count = 0;
        rune = 0;
        health = 20;

        SetCountText();
        SetRuneText();
        SetHealthText();

        winText.text = "";
        loseText.text = "";
       // runeText.text = "";

      //  button.gameObject.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Book"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            //print("Journal Obtained");
        }

        if (other.gameObject.CompareTag("Rune"))
        {
            other.gameObject.SetActive(false);
            rune = rune + 1;
            SetRuneText();
            //print("Rune Obtained");
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            health = health - 1;
            SetHealthText();
        }
    }

    void SetCountText()
    {
        countText.text = "Journals: " + count.ToString();

        if (count >= 3)
        {
            winText.text = "You Win!";
          //  button.gameObject.SetActive(true);
        }

    }

    void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();

        if (health <= 0)
        {
            loseText.text = "Game Over!";
           // button.gameObject.SetActive(true);
        }
    }

    void SetRuneText() 
    {
           
           runeText.text="Runes: " + rune.ToString();
            
            if (rune == 1) 
            {
                runeText.text= "You have "+ count.ToString()+" Runes";
               // button.gameObject.SetActive(true);  
            }
    }


}
