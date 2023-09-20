using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetComponent : MonoBehaviour
{
    public void ProcessHit()
    {
        GameManager.Instance.IncrementScore();
        gameObject.SetActive(false);
        Invoke("ResetTarget",5.0f);
        // TODO React to hit 
    }
    void ResetTarget()
    {
        gameObject.SetActive(true);
        transform.parent.GetComponent<Renderer>().material.color = Color.green;
    }

}
