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
    
    
    
    
    //Door
    private bool playerInZone;                  //Check if the player is in the zone
    private bool doorOpened;                    //Check if door is currently opened or not

    private Animation doorAnim;
    private BoxCollider doorCollider;           //To enable the player to go through the door if door is opened else block him

    public GameObject doorControllerGo;
    
    enum DoorState
    {
        Closed,
        Opened,
        Jammed
    }

    DoorState doorState = new DoorState();      //To check the current state of the door
    
    // private void DoorInteract()
    // {
    //     print("OPEEEEN");
    //     doorOpened = false;                     //Is the door currently opened//Player not in zone
    //     doorState = DoorState.Closed;           //Starting state is door closed
    //
    //     
    //
    //     doorAnim = transform.parent.gameObject.GetComponent<Animation>();
    //     doorCollider = transform.parent.gameObject.GetComponent<BoxCollider>();
    //     //To Check if the player is in the zone
    //     if (playerInZone)
    //     {
    //         if (doorState == DoorState.Opened)
    //         {
    //             //txtToDisplay.GetComponent<Text>().text = "Press 'E' to Close";
    //             doorCollider.enabled = false;
    //         }
    //         else if (doorState == DoorState.Closed)
    //         {
    //             //txtToDisplay.GetComponent<Text>().text = "Press 'E' to Open";
    //             doorCollider.enabled = true;
    //         }
    //         else if (doorState == DoorState.Jammed)
    //         {
    //             //txtToDisplay.GetComponent<Text>().text = "Needs Key";
    //             doorCollider.enabled = true;
    //         }
    //     }
    //
    //
    //     
    //     if (doorState == DoorState.Closed && !doorAnim.isPlaying)
    //     {
    //         doorAnim.Play("Door_Open");
    //         doorState = DoorState.Opened;
    //     }
    //
    //     if (doorState == DoorState.Opened && !doorAnim.isPlaying)
    //     {
    //         doorAnim.Play("Door_Close");
    //         doorState = DoorState.Closed;
    //     }
    // }

    
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
                DoorController dc = doorControllerGo.GetComponent<DoorController>();
                dc.Interact();
               
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
