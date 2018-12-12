using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCannonFire : MonoBehaviour {

    public float fireRate;
    private float nextFire;
    public List<GameObject> shot;
    public Transform shotSpawn;
    public int activeWeaponIndex;
    private KeyCode[] keyCodes = {
        KeyCode.Alpha1,
        KeyCode.Alpha2,
        KeyCode.Alpha3,
        KeyCode.Alpha4,
        KeyCode.Alpha5,
        KeyCode.Alpha6,
        KeyCode.Alpha7,
        KeyCode.Alpha8,
        KeyCode.Alpha9
    };

    // Update is called once per frame
    void Update () {
        for (int i = 0; i < keyCodes.Length; i++) {
            if (Input.GetKeyDown(keyCodes[i])) {
                activeWeaponIndex = i;
                if(activeWeaponIndex + 1 > shot.Capacity) {
                    activeWeaponIndex = shot.Capacity - 1;
                }
            }
        }
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFire) {
            nextFire = Time.time + fireRate;
            if (activeWeaponIndex >= 0) {
                Instantiate(shot[activeWeaponIndex], shotSpawn.position, shotSpawn.rotation);
            }
            
        }
    }
}
