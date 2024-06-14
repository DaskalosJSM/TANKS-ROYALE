using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum GameState{
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour
{
    // Declaración del estado del juego
    public static GameManager sharedInstance;
    public GameState currentGameState = GameState.menu;
   
    // Start is called before the first frame update
    private void Awake() 
    {
        // Inicializo el singleton en el primer script 
        // que despierte y enfatizo con el siguiente fragmento
     if (sharedInstance == null)
     {
        sharedInstance = this;
     }    
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
         if(Input.GetKeyDown(KeyCode.P))
        {
        BackTomenu();       
        }
    }
    // Función encargado de iniciar la scena de juego
    public void StartGame()
    {
        SetGameState(GameState.inGame);
    } 
    // Función encargado de iniciar la scena de final de juego
    public void GameOver()
    {
        SetGameState(GameState.gameOver);
        SceneManager.LoadScene("GameOver");
    }
    // Función encargado de iniciar la scena menú principal
    public void BackTomenu()
    {
        SetGameState(GameState.menu);
    }
    private void SetGameState (GameState newGameState)
    {
        if(newGameState == GameState.menu){
            //TODO: colocar la logica del menu
        }
        else if (newGameState == GameState.inGame)
        {
            //TODO: colocar la logica del juego
        }
        else if (newGameState == GameState.gameOver)
        {
            //TODO: colocar la logica del game over
        }
        this.currentGameState = newGameState;
    }
}

