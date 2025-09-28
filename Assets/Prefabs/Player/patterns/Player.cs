using UnityEngine;

public class Player 
{
    private float speed;
    private float aceleration;

    public Player(float speed, float aceleration)
    {
        this.speed = speed;
        this.aceleration = aceleration;
    }

    public float Velocity 
    { 
        get { return speed; } 
        set { speed = value; }
    }

    public float Aceleration 
    { 
        get { return aceleration; } 
        set { aceleration = value; }
    }

}
