using UnityEngine;


public class LoopingBackground : MonoBehaviour
{
    
    public float speed;
    [SerializeField]
    private Renderer bgRenderer;
    
    
    void Update()
    {
        bgRenderer.material.mainTextureOffset+= new Vector2(SpeedManager.Instance.gameSpeed * Time.deltaTime, 0);
    }
}
