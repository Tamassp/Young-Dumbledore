using System.Collections;
using Unity.Template.VR;
using UnityEngine;

public class SpellCollision : MonoBehaviour
{
    private ArrayList avadaKedavra = new() { 1, 2, 3 };
    private ArrayList alohomora = new() { 3,6,9,8,7,4,1,2,5 };

    private ArrayList currentSpell = new ();

    
    //Projectile
    public GameObject projectile;
    public float launchVelocity = 700f;
    private void Fire()
    {
        //if (!Input.GetButtonDown("Fire1")) return;
        var transform1 = transform;
        var ball = Instantiate(projectile, transform1.position, transform1.rotation);
        ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity, 0)); 
    }
    
    
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
                // GameObject go = new GameObject();
                // go.AddComponent<ProjectileLauncher>();
                // ProjectileLauncher launcher = go.GetComponent<ProjectileLauncher>();
                // ProjectileLauncher launcher = new ProjectileLauncher();
                
                Fire();
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
        if (other.gameObject.tag == "SpellArea")
        {
            currentSpell.Clear();
            print("EXITSPEALLAREA");
        }
        if (other.gameObject.tag == "Hitbox")
        {
            print("EXIT");
        }
        
        
    }
}
