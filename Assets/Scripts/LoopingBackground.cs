using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    [SerializeField]
    private Renderer bgRenderer;
    //Reference to the speed manager
    void Update()
    {
        if(GameManager.Instance.isGameOver) return;
        
        bgRenderer.material.mainTextureOffset+= new Vector2(SpeedManager.Instance.gameSpeed * Time.deltaTime, 0);
    }
}
