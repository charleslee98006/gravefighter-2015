using UnityEngine;
using System.Collections;

public class playerAction : MonoBehaviour
{
    private bool action;

    void Update()
    {
        inputListener();
    }

    void inputListener()
    {
        action = Input.GetButtonDown(Inputs.action);
    }

    void OnTriggerStay(Collider hit)
    {
        if(hit.GetComponent<plot>())
        {
            if(action)
            {
                hit.GetComponent<plot>().executeAction();
            }
        }
    }
}
