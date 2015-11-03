using UnityEngine;
using System.Collections;

// This script destroys all objects in range, used for scenes were objects could fall true the ground
// Create a emptyGameObject, add a boxCollider, set it to trigger, attach the script.
// you could expand it with a Respawn so the objects respawn back insted of being destroyed
public class CatchAll : MonoBehaviour
{
private int totalDestroyed;
private bool isDebug = false;

  void Start()
  {
    totalDestroyed = 0;
  }
  
  void OnTriggerEnter(Collider otherId)
  {
    // On trigger enter, destroy otherId
    Destroy(otherId.gameObject);
    // counter to register the destroyed objects
    totalDestroyed = totalDestroyed + 1;
    // print a Debug.log to the console
      if(true == isDebug)
      {
        //Debug.Log("TotalDestroyed", totalDestroyed);
      }
  }
}
