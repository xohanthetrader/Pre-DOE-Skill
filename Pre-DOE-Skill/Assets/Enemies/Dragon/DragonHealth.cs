using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonHealth : MonoBehaviour,IEnemyHealthManager,IBoss
{
        
    public delegate void Death();

    private Death death;
    
    public float Health = 100;
    public int currRoom;

    public bool isBoss;
    public void TakeDamage(float damage, BulletTypes types)
    {
        print("damge taken");
        Health -= damage * 0.5f;
        if (Health <= 0)
        {
            OnDeath();
            Destroy(gameObject);
        }
    }

    public void RoomActive(int room)
    {
        if (room == currRoom)
        {
            gameObject.SetActive(true);
        }
    }

    public void JoinDeath(ref IRoomMan room)
    {
        death += room.DeathCounter;    
    }

    

    public bool IsBoss() => isBoss;
    public void OnDeath(){
        if (isBoss)
        {
            
        }
    }
}
