using UnityEngine;
using System.Collections;

public class gravestone : MonoBehaviour
{
    public plot parentPlot;

    public int health;

    public float damageInterval;
    private float maxDamageInterval;

    void Awake()
    {
        maxDamageInterval = damageInterval;
    }
    //remove, for testing only
    public bool destroy;
    void Update()
    {
        if(destroy)
        {
            onDestroy();
        }
    }
    //

    void onDestroy()
    {
        parentPlot.destroyGravestone();
    }

    /*void OnTriggerStay(Collider hit)
    {
        if(hit.GetComponent<//enemy component>())
        {
            damageInterval -= Time.deltaTime;
            if(damageInterval <= 0)
            {
                health--;
                damageInterval = maxDamageInterval;
            }
        }
    }*/

}
