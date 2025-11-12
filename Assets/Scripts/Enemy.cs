using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject killParticles;
    [SerializeField] int hitPoints=5;
    [SerializeField] int pointsValue=5;
    ScoreBoard scoreBoard;

    void Start()
    {
        scoreBoard=FindFirstObjectByType<ScoreBoard>();
    }

    void OnParticleCollision(GameObject other)
    {
        processHit();
    }

    void processHit(){

        hitPoints-=1;

        if(hitPoints<=0){
            scoreBoard.increaseScore(pointsValue);
            Instantiate(killParticles,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }

    }

}
