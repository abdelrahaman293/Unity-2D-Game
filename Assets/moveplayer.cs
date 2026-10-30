
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingObj : MonoBehaviour
{
    private Rigidbody2D reg;
    private Animator anim;
    public string isrun;

    // Start is called before the first frame update
    void Start()
    {
        reg = GetComponent<Rigidbody2D>();
        anim = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        int x = 0;
        int y = 0;

        if (Input.GetKey("right"))
        {
            x = 10;
            transform.localScale = new Vector3(3, 3, 1);
            anim.SetBool(isrun, true);
        }
        else if (Input.GetKey("left"))
        {
            x = -10;
            transform.localScale = new Vector3(-3, 3, 1);
            anim.SetBool(isrun, true);
        }
        else if (Input.GetKey("up"))
        {
            y = 10;
            anim.SetBool(isrun, false);
        }
        else if (Input.GetKey("down"))
        {
            y = -10;
            anim.SetBool(isrun, false);
        }

        // «· ⁄œÌ·: «·—ÃÊ⁄ ≈·Ï Idle ⁄‰œ  —ﬂ √“—«— «·Ì„Ì‰ Ê«·‘„«·
        if (x == 0)
        {
            anim.SetBool(isrun, false);
        }

        reg.AddForce(new Vector2(x, y));
    }
}
