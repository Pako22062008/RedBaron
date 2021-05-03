using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager GameManager;
    
    public void OnTriggerEnter()
    {
        GameManager.CompleteLevel();
        
    }
    
    

}
