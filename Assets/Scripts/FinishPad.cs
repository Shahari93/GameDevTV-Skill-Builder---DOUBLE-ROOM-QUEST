// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv 
using UnityEngine;

public class FinishPad : MonoBehaviour
{
    private GameHandler gameHandler;
    [SerializeField] private ParticleSystem finishPadParticles;

    private void Start()
    {
        //Challenge 3: 
        gameHandler = FindObjectOfType<GameHandler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            //This next line of code will console log an error until Challenge 3 is complete.
            gameHandler.RemovePlayerCubeFromList(other.gameObject.GetComponent<PlayerMovement>());
            Destroy(other.gameObject);
            //Challenge 4:  
            finishPadParticles.Play();
        }
    }
}
