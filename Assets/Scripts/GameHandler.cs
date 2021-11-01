// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv 

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject youWinPanel = null;
    [SerializeField] private GameObject youLosePanel = null; // Floor Is Lava Challenge 

    [SerializeField] private List<PlayerMovement> allPlayerCubes = new List<PlayerMovement>();

    private void Start()
    {
        allPlayerCubes.AddRange(FindObjectsOfType<PlayerMovement>());
        youWinPanel.SetActive(false);
        youLosePanel.SetActive(false); // Floor Is Lava Challenge 
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
            youWinPanel.SetActive(true);
        }
    }

    // Floor Is Lava Challenge 
    public void CheckIfPlayerHitSpike()
    {
        for (int i = 0; i < allPlayerCubes.Count; i++)
        {
            if(allPlayerCubes[i].IsGameOver == true)
            {
                youLosePanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}