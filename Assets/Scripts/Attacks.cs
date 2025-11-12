using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attacks : MonoBehaviour
{

    // [SerializeField] GameObject laser_left;
    // [SerializeField] GameObject laser_right;
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crosshair;
    [SerializeField] Transform targetPoint;
    [SerializeField] float targetDistance=100f;
    bool laserIsOn=false;

    void Start() {
        Cursor.visible=false;
    }

    void Update() {

        firingLasers();
        moveCrosshair();
        moveTargetPoint();
        aimLasers();

    }

    public void OnLaser(InputValue value){
        laserIsOn=value.isPressed;
    }

    void firingLasers(){

        // var emissionModule_left=laser_left.GetComponent<ParticleSystem>().emission;
        // emissionModule_left.enabled=laserIsOn;
        // var emissionModule_right=laser_right.GetComponent<ParticleSystem>().emission;
        // emissionModule_right.enabled=laserIsOn;

        foreach(GameObject laser in lasers){
            var emissionModule=laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled=laserIsOn;
        }

    }

    void moveCrosshair(){
        crosshair.position=Input.mousePosition;
    }

    void moveTargetPoint(){
        Vector3 targetPointPosition=new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetDistance);
        targetPoint.position=Camera.main.ScreenToWorldPoint(targetPointPosition);
    }

    void aimLasers(){
        foreach(GameObject laser in lasers){
            Vector3 fireLasers=targetPoint.position-transform.position;
            Quaternion rotateTowardsTarget=Quaternion.LookRotation(fireLasers);
            laser.transform.rotation=rotateTowardsTarget;
        }
    }

}
