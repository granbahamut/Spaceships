using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalShot : MonoBehaviour {

    public float speed;
    public float dispersionRange;
    private float dispersion;
    private Rigidbody2D rb2d;
    public float range;

    private void Awake() {
        Destroy(gameObject, range);
    }

    // Use this for initialization
    void Start() {
        dispersion = Random.Range(-dispersionRange, dispersionRange);
        Vector2 v2 = new Vector2(dispersion, 1);
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(v2 * speed, ForceMode2D.Force);
    }
}
