using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathPlaneComponent : MonoBehaviour
{
    // Start is called before the first frame update
  
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {   //Restarts a level.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
