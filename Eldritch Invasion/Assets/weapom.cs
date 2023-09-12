using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapom : MonoBehaviour
{
    public GameObject projectile;
    public Transform shotPoint;
    public float timeBeforeShots;
    private float fireRate;

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        transform.rotation = rotation;

        // 0 esquerdo, 1 direito
        if (Input.GetMouseButton(0))
        {
            if (Time.time >= fireRate)
            {
                Instantiate(projectile, shotPoint.position, transform.rotation);
                fireRate = Time.time + timeBeforeShots;
            }
        }
    }
}
