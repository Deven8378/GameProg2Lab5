using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    
    public GameObject particleSystemToSpawn;
    public Transform spawnPoint;
    public AudioSource source;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //TODO Shooting logic
            Instantiate(particleSystemToSpawn,spawnPoint.position,spawnPoint.rotation);
            source.Play();
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F,0.5F,0));
            RaycastHit hit;
            //Happens when you shoot but not if you hit
            //Playing sound effect of weapon and guns here
            //Playing particles effect for bullet happens here
            if (Physics.Raycast(ray, out hit))
            {
                //What you call here is if your ray hits something
                //Hurting an NPC
                if (hit.collider.tag == "Target")
                {
                    TargetComponent tc = hit.collider.gameObject.GetComponent<TargetComponent>();
                    if (tc != null)
                    {
                        tc.ProcessHit();
                    }
                }
            }
            
        }
        
    }
}
