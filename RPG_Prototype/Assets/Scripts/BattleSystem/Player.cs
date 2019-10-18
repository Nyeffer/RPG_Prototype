using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Public Variables
    public int maxHp; // Maximum Health, required for healing

    // Private Variables
    private int curHp; // Health that interacts with Damage and Heal

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    // Getters
    public int GetHp() { // Function to GET assess to the CurrentHp integer
        return curHp;
    }
    

    
}
