using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Drawing;

public class PlayerControler : MonoBehaviour
{

    private Rigidbody rg;
    private Vector3 moveMent;
    private float moveHorizontal, moveVertical;
    public int speed;
    public Text countPoint;
    public Text Wintext;
    private int point;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        point = 0;
        setCountPoint();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        moveMent = new Vector3(moveHorizontal, 0f, moveVertical);
        rg.AddForce(moveMent * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            point++;
            setCountPoint();
        }
    }
    void setCountPoint()
    {
        countPoint.text = "Point: " + point.ToString();
        if (point >= 8)
        {
            Wintext.text = "You Win ...!";
        }
    }

}
