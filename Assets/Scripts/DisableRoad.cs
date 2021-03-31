using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRoad : MonoBehaviour
{
    //public GameObject road;
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            Debug.Log("collision");
            this.transform.parent.gameObject.SetActive(false);
            GameManager.instance.canAppear = true;
        }
    }
}
