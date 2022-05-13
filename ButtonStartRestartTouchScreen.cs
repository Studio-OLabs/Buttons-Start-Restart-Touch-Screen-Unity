using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Boas práticas de programação: variáveis letra minúscula e funções letra maiúscula
public class ButtonStartRestart : MonoBehaviour
{
 
    //Declaração dos botões Start e Restart
    public Button start;
    public Button restart;
	
	 void Start()
    {
        //Tempo do jogo estar parado
        Time.timeScale = 0;
        //Aparecendo o botão Start para iniciar o jogo
        start.gameObject.SetActive(true);
        //Não aparecendo o botão Restart
        restart.gameObject.SetActive(false);
	}
	
	//Iniciando o jogo
    //SetActive-> verifica se o objeto está ativo ou não na cena
	public void Starting()
    {
        start.gameObject.SetActive(false);
        //Tempo do jogo iniciado
        Time.timeScale = 1;
    }

    //Reiniciando o jogo
    public void Restart()
    {
        restart.gameObject.SetActive(false);
        //Carregar novamente a primeira cena do jogo (cena "zero")
        SceneManager.LoadScene(0);
    }

}