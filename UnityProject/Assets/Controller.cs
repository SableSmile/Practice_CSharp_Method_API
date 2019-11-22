using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("移動速度"),Range(1,50)]
    public float Speed = 20f;
    public Rigidbody2D Rig;
    public SpriteRenderer Sr;
    private float direction;
    float force;
    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        force = Rig.velocity.x * Time.deltaTime;
        if (force > 0)
        {
            Sr.flipX = false;
        }
        else
            Sr.flipX = true;
    }
    void move()
    {
        direction = Input.GetAxisRaw("Horizontal") * Speed ;
        Rig.AddForce(new Vector2(direction,0));
        //transform.Rotate(0, Speed, 0);
    }
}
