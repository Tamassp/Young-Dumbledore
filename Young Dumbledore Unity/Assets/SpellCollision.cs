using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCollision : MonoBehaviour
{
    private ArrayList avadaKedavra = new ArrayList() { 1, 2, 3 };
    private ArrayList alohomora = new ArrayList() { 3,6,9,8,7,4,1,2,5 };

    private ArrayList currentSpell = new ArrayList();

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
                currentSpell.Add(1);
                break;
            case "Hitbox2" :
                print("HITBOX2");
                currentSpell.Add(2);
                break;
            case "Hitbox3" :
                print("HITBOX3");
                currentSpell.Add(3);
                break;
            case "Hitbox4" :
                print("HITBOX4");
                currentSpell.Add(4);
                break;
            case "Hitbox5" :
                print("HITBOX5");
                currentSpell.Add(5);
                break;
            case "Hitbox6" :
                print("HITBOX6");
                currentSpell.Add(6);
                break;
            case "Hitbox7" :
                print("HITBOX7");
                currentSpell.Add(7);
                break;
            case "Hitbox8" :
                print("HITBOX8");
                currentSpell.Add(8);
                break;
            case "Hitbox9" :
                print("HITBOX9");
                currentSpell.Add(9);
                break;
        }

        bool t = true;
        if (currentSpell.Count == avadaKedavra.Count)
        {
            for (int i = 0; i < currentSpell.Count; i++)
            {
                if (currentSpell[i].ToString() != avadaKedavra[i].ToString())
                {
                    t = false;
                }
            }

            if (t)
            {
                print("AVADAKEDAVRA");
            }
        }
        if (currentSpell.Count == alohomora.Count)
        {
            for (int i = 0; i < currentSpell.Count; i++)
            {
                if (currentSpell[i].ToString() != alohomora[i].ToString())
                {
                    t = false;
                }
            }

            if (t)
            {
                print("ALOHOMORA");
            }
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
