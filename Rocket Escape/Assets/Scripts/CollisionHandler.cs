using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("friendly");
                    break;
            case "Finish":
                Debug.Log("you finished!");
                    break;
            default:
                Debug.Log("You lost");
                break;
        }
    }
}
