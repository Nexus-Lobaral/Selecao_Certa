using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;

public class SistemaDeSeleção : MonoBehaviour
{
    private static SistemaDeSeleção instance;
    protected GameObject obj;
    protected TextMeshProUGUI text;
    public Pessoa[] pessoas;
    public Pessoa pessoaAtual; 
    [SerializeField] private TextAsset[] dialogos;
    [SerializeField] private Sprite[] fotosPessoasMasc;
    [SerializeField] private Sprite[] fotosPessoasFem;
    public int indice;
    [SerializeField] private DisplayCurriculo displayCurriculo;

    private void Awake()
    {
        // displayCurriculo = GetComponent<DisplayCurriculo>();
        if (instance != null)
        {
            Debug.Log("Tem mais de um sistema de seleção na cena");
        }
        DontDestroyOnLoad(this);
        instance = this;
        
        pessoas = new Pessoa[3];
        if (dialogos != null && fotosPessoasMasc != null && fotosPessoasFem != null)
        {

            for (int i = 0; i < pessoas.Length; i++)
            {
                var dialogoAleatorio = dialogos[Random.Range(0, dialogos.Length)];
                pessoas[i] = new Pessoa(fotosPessoasMasc[i], dialogoAleatorio);

               if (pessoas[i].genero == "feminino")
               {
                    pessoas[i].imagemPessoa = fotosPessoasFem[i];
               }
            }
        }
        else
        {
            Debug.Log("Erro por falta de TextAssets ou imagens suficientes para cada pessoa");
        }
        indice = 0;
        pessoaAtual = pessoas[indice];
    }
    private void Start()
    {
        
        

    }


    public static SistemaDeSeleção GetInstance()
    {
        return instance;
    }

    public void MudarIndiceNext()
    {
        if (indice < 2)
        {
            indice++;
            pessoaAtual = pessoas[indice];
            displayCurriculo.SetImageCurriculo(pessoas[indice].imagemPessoa);
            displayCurriculo.SetNamePersonagem(pessoas[indice].GetNomeCompleto());

        }
    }
    public void MudarIndicePrevious()
    {
        if (  indice > 0)
        {
            indice--;
            pessoaAtual = pessoas[indice];
            displayCurriculo.SetImageCurriculo(pessoas[indice].imagemPessoa);
            displayCurriculo.SetNamePersonagem(pessoaAtual.GetNomeCompleto());
        }
        
    }



}
