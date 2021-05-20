using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    
    public GameObject ammo;
    public Transform shotDir;
    public float offset;

    public int totalBullet = 3;
    public int numberOfBullet;

    private float timeShot;
    public float starTime;

    public bool win = false;

    public CartridgeSystem script;
    void Start()
    {
        script = GetComponent<CartridgeSystem>();
    }
   
    void Update()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        if(rot_z > -40 && rot_z < 60)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, rot_z - offset);
        }

        if (timeShot <= 0)
        {
            if (Input.GetMouseButtonDown(0) && (totalBullet > 0) && (totalBullet <= numberOfBullet))
            {
                Instantiate(ammo, shotDir.position, transform.rotation);
                timeShot = starTime;
                totalBullet -= 1;
                script.cartridge -= 1;
            }
            
        }
        else
        {
            timeShot -= Time.deltaTime;
        }

        if (GameObject.FindGameObjectsWithTag("Bandit").Length == 0 && totalBullet >= 0)
        {
            Debug.Log("Win");
            win = true; 
            totalBullet = 0;
        }

    }

}
