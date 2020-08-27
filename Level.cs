
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;
    SceneLoader sceneloader;
   
    public void CountBlocks()
    {
        breakableBlocks++;
    }

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks<= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
