using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hitbox")
        {
            print("ENTER");
        }
        switch (other.gameObject.name)
        {
            case "Hitbox1" :
                print("HITBOX1");
                break;
            case "Hitbox2" :
                print("HITBOX2");
                break;
            case "Hitbox3" :
                print("HITBOX3");
                break;
            case "Hitbox4" :
                print("HITBOX4");
                break;
            case "Hitbox5" :
                print("HITBOX5");
                break;
            case "Hitbox6" :
                print("HITBOX6");
                break;
            case "Hitbox7" :
                print("HITBOX7");
                break;
            case "Hitbox8" :
                print("HITBOX8");
                break;
            case "Hitbox9" :
                print("HITBOX9");
                break;
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Hitbox")
        {
            print("STAY");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hitbox")
        {
            print("EXIT");
        }
        
    }
}
