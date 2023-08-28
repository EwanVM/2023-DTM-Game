using UnityEngine;
using System.Collections;

public class GunFire : MonoBehaviour
{

    public GameObject projectile;

    public float speed = 40f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, transform.position, transform.rotation);

        }
    }
}
