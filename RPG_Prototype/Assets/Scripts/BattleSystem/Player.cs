using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Public Variables
    public int maxHp; // Maximum Health, required for healing
    public int atk; // Atk Stat that the player currently have
    public int def; // Def Stat that the player currently have
    public float atkGrowth; // decimal number that multiplies the Atk stat per Level count
    public float defGrowth; // decimal number that multiplies the Def Stat per Level count
    public float hpGrowth; // decimal number that multiples the Hp stat per level count
    
    
    // Private Variables
    private int curHp; // Health that interacts with Damage and Heal
    private int Level; // the integer that Stats are multiplied from
    private int atkVal; // the integer that's actively use in Damage counting
    private int defVal; // The integer that's actively use to decrease Damage taken 

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Level up
    public void LevelUp() { // Calculates the stat increase
        atkVal = (int)(atk * ((atk * atkGrowth) + 1));
		maxHp = (int)(maxHp * ((maxHp * hpGrowth) + 1));
		defVal = (int)(def * ((def * defGrowth) + 1));
		curHp = maxHp;
    }
   

    // Getters
    public int GetHp() { // Function to GET assess to the CurrentHp integer
        return curHp;
    }

    public int GetAtk() { // Function to GET assess to the AtkVal integer for Damage Counting
        return atkVal;
    }

    public int GetDef() { // Function to GET assess to the DefVal integer to decrease Damage taken
        return defVal;
    }
    

    
}
