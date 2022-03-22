using UnityEngine;

public class Moving : MonoBehaviour
{
    public float cubeDistance;
    public float cubeSpeed;
   
    void Start()
    {
        DestroyObject();
    }
     
    void DestroyObject()
    {
        
        Destroy(this.gameObject, cubeDistance / cubeSpeed);
       
    }

    void Update()
    {
        this.transform.Translate(new Vector3(-cubeSpeed * Time.deltaTime, 0.0f, 0.0f));
    }


}
