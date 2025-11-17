using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    [SerializeField] GameObject killParticlesPlayer;
    // void OnCollisionEnter(Collision other)
    // {
    //     if(other.gameObject.tag=="Respawn"){
    //         Debug.Log("crashed!!");
    //     }
    // }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Portal"){
            Debug.Log("entered the portal!!");
        }
        else{
            Instantiate(killParticlesPlayer,transform.position,Quaternion.identity);
            Destroy(gameObject);
            SceneManager.LoadScene("MainMenu");
        }
    }

}
