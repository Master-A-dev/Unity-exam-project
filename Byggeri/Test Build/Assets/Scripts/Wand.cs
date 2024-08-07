using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Wand : MonoBehaviour
{
    [SerializeField] private GameObject wand;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnpoint;

    private GameObject bulletinst;

    private Vector2 worldPos;
    private Vector2 direction;


    // Update is called once per frame
    void Update()
    {
        WandRotation();
        WandShooting();
    }

    private void WandRotation()
    {
        worldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        direction = (worldPos - (Vector2)wand.transform.position).normalized;
        wand.transform.right = direction;
    }

    private void WandShooting()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            bulletinst = Instantiate(bullet, bulletSpawnpoint.position, wand.transform.rotation);
        }
    }
}
