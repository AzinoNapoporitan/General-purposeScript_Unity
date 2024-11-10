using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimetionControler : MonoBehaviour
{
    [SerializeField] Animator[]   AnimatorArray;
    void Update()
    {

        for (int i = 0; i < AnimatorArray.Length; i++)
        {
            AnimatorArray[i].SetBool("GameOverFlag",true);
        }
    }
}
   
