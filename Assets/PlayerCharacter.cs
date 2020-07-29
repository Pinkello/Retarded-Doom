using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerCharacter: MonoBehaviour
{
    private int _health;
    // Start is called before the first frame update
    void Start()
    {
        _health = 5;
    }

    public void Hurt(int damage)
    {
        _health -= damage;
        Debug.Log("Kondycja: " + _health);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
