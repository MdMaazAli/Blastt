using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed=10f;
    [SerializeField] float xClampRange=10f;
    [SerializeField] float yClampRange=10f;

    [SerializeField] float controlPitch=20f;
    [SerializeField] float controlRotation=20f;
    [SerializeField] float rotationSpeed=10f;

    Vector2 movement;

    void Update()
    {
        processTranslation();
        processRotation();
    }

    void processRotation(){

        Quaternion targetRotation=Quaternion.Euler(-controlPitch*movement.y,0f,controlRotation*movement.x);
        transform.localRotation=Quaternion.Lerp(transform.localRotation,targetRotation,rotationSpeed*Time.deltaTime);
        // transform.localPosition= Quaternion.Euler(pitch,yaw,roll);


        // Quaternion.Lerp
        // Color.Lerp
        // Mathf.Lerp

    }
    
    public void OnMove(InputValue value){
        movement=value.Get<Vector2>();
    }

    void processTranslation(){

        float xOffset=-movement.x*controlSpeed*Time.deltaTime;
        float yOffset=movement.y*controlSpeed*Time.deltaTime;
        float rawX=transform.localPosition.x+xOffset;
        float rawY=transform.localPosition.y+yOffset;
        
        float clampX=Mathf.Clamp(rawX,-xClampRange,xClampRange);
        float clampY=Mathf.Clamp(rawY,-yClampRange,yClampRange);

        transform.localPosition=new Vector3(clampX,clampY,0f);

    }

    
}
