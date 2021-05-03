using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public int points = 0;
    public bool touchleft = false;
    public bool touchright = false;
  

    private void OnGUI()
    {
        GUI.Label(new Rect(740, 80, 2000, 4000), "Score: " + points);
        
    }
   


   
    void FixedUpdate()
    {
        
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        /*
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    */

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 2)
                        touchleft = true;
                    if (touch.position.x > Screen.width / 2)
                        touchright = true;
                    break;
                case TouchPhase.Ended:
                    touchleft = false;
                    touchright = false;
                    break;
                
                  
            }
        }
        if (touchleft == true)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (touchright == true)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }





    }
}
