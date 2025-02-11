using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Monster
{
    protected override void Init()
    {
        base.Init();
        
        hp = 3f;
        speed = 5f;
        isMove = true;
    }
}
