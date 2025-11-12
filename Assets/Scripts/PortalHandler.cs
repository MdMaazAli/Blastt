using System;
using UnityEditor;
using UnityEditor.Rendering.HighDefinition;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalHandler : MonoBehaviour
{

    [SerializeField] private String sceneName;
    [SerializeField] GameObject portal;

    #if UNITY_EDITOR
    [SerializeField] private SceneAsset sceneAsset;

    ScoreBoard scoreBoard;

    void Start()
    {
        scoreBoard=FindFirstObjectByType<ScoreBoard>();
    }

    private void OnValidate()
    {
        if (sceneAsset != null)
        {
            sceneName = sceneAsset.name;
        }
    }
    #endif

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player" && scoreBoard.getScore()>=300){
            Debug.Log("entering the next scene!!");
            Renderer renderer=portal.GetComponent<Renderer>();
            Material material=renderer.material;
            material.EnableKeyword("_EMISSION");
            SceneManager.LoadScene(sceneName);
        }
        else{
            Debug.Log("you did not get the key!!");
        }
    }

}
