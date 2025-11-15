using UnityEngine;

public class MainMenuUIElements : MonoBehaviour
{
    [SerializeField] float oscillationSpeed = 10.0f;
    [SerializeField] float amplitude = 5.0f;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        processOscillation();
    }

    void processOscillation()
    {
        float offset = (Mathf.Sin(Time.time))*oscillationSpeed;
        transform.position = startPos+new Vector3(offset,0.0f,0.0f);
    }
}
