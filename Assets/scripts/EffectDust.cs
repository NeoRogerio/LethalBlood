using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDust : MonoBehaviour
{   
    public GameObject prefabDust;
    public Transform point;
    public float livingTime;

    public void Instantiate(){
        GameObject temp = Instantiate(prefabDust, point.position, Quaternion.identity) as GameObject;
        if(livingTime > 0){
            Destroy(temp, livingTime);
        }
    }
}
