using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float moveAccel;

    private float horAxis;
    private float verAxis;

    private Rigidbody rigid;
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }
	void Update ()
    {
        inputListener();
        movementController();
	}

    void inputListener()
    {
        horAxis = Input.GetAxis(Inputs.horAxis);
        verAxis = Input.GetAxis(Inputs.verAxis);
    }

    void movementController()
    {
        Vector3 horVel = (Vector3.right * horAxis) * moveSpeed;
        Vector3 verVel = (Vector3.up * verAxis) * moveSpeed;
        Vector3 newVel = horVel + verVel;
        rigid.velocity = newVel;
    }
}
