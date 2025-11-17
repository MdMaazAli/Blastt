using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    [SerializeField] GameObject killParticlesPlayer;
    [SerializeField] GameObject tryAgainWindow;
    // void OnCollisionEnter(Collision other)
    // {
    //     if(other.gameObject.tag=="Respawn"){
    //         Debug.Log("crashed!!");
    //     }
    // }

    void Start()
    {
        tryAgainWindow.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Portal"){
            Debug.Log("entered the portal!!");
        }
        else{
            Instantiate(killParticlesPlayer,transform.position,Quaternion.identity);
            Destroy(gameObject);
            tryAgainWindow.SetActive(true);
            // SceneManager.LoadScene("MainMenu");
        }
    }

}
