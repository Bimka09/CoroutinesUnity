using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MakeDamage : MonoBehaviour
{
    public PoliceMan policeMan;

    public void ApplyDamage()
    {
        policeMan.TakeDamage(50);
        Debug.Log($"{policeMan.Health}");
    }
}
