using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove  // interface는 앞에 대문자 I가 붙어야함
{
    public void Move()
    {
        Debug.Log("움직이는 기능");
    }

    public void Stop()
    {
        Debug.Log("멈추는 기능");
    }
}
