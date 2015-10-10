using UnityEngine;
using System.Collections;

public class plot : MonoBehaviour, IDamageable<int>
{
    public bool hasGravestone;
    public bool hasBody;
    public bool hasAliveBody;

    public Vector3 gravePosOffset;
    public Vector3 bodyPosOffset;

    public GameObject body;
    private GameObject currentBody;
    public GameObject gravestone;
    private GameObject currentGravestone;

    public float spawnBodyInterval;
    private float maxSpawnBodyInterval;

    public GameObject gameController;

    void Awake()
    {
        maxSpawnBodyInterval = spawnBodyInterval;
    }

    void Update()
    {
        if(hasBody && !hasAliveBody)
        {
            spawnBodyInterval -= Time.deltaTime;
            if (spawnBodyInterval <= 0)
            {
                spawnBody();
                spawnBodyInterval = maxSpawnBodyInterval;
            }
        }
    }
    public void executeAction()
    {
        if(hasGravestone)
        {
            buryBody();
        }
        else
        {
            buildGravestone();
        }
    }

    void buildGravestone()
    {
        Vector3 spawnPos = transform.position + gravePosOffset;
        currentGravestone = Instantiate(gravestone, spawnPos, Quaternion.identity) as GameObject;
        currentGravestone.GetComponent<gravestone>().parentPlot = this;
        hasGravestone = true;
    }

    public void destroyGravestone()
    {
        Destroy(currentGravestone);
        currentGravestone = null;
        hasGravestone = false;
    }
    
    void buryBody()
    {
        hasBody = true;
    }

    void spawnBody()
    {
        Vector3 spawnPos = transform.position + bodyPosOffset;
        //currentBody = Instantiate(body, spawnPos, Quaternion.identity) as GameObject;
        //currentBody.GetComponent</* player body class*/>().parentPlot = this;
        hasAliveBody = true;
        hasBody = !hasAliveBody;
    }

    public void destroyBody()
    {
        Destroy(currentBody);
        currentBody = null;
        hasAliveBody = false;
    }

}
