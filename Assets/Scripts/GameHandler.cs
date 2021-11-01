// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv 

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject youWinText = null;

    [SerializeField] private List<PlayerMovement> allPlayerCubes = new List<PlayerMovement>();

    private void Start()
    {
        allPlayerCubes.AddRange(FindObjectsOfType<PlayerMovement>());
        youWinText.SetActive(false);
    }

    public void RemovePlayerCubeFromList(PlayerMovement thisCube)
    {
        allPlayerCubes.Remove(thisCube);
        CheckIfLevelComplete();
    }

    private void CheckIfLevelComplete()
    {
        if (allPlayerCubes.Count <= 0)
        {
            youWinText.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}