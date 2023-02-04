using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
    	if (other.CompareTag("Player")){  // other.tag == "Player"
    		print("Yay, you did it! \n Moving to next level...");
    	}
    }
}
