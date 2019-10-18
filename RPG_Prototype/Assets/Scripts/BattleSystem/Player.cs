using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Private Variables
    private int maxHp = 0; // Maximum Health, required for healing
    private int curHp; // Health that interacts with Damage and Heal

    // Public Variables
    public int hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Setters
    public void SetHp(int health) {
        hp = health;
    }

    // Getters
    public int GetCurHp() {
        return curHp;
    }

    public int GetMaxHp() {
        return maxHp;
    }
}
