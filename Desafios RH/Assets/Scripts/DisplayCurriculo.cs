using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class DisplayCurriculo : MonoBehaviour
{
    [SerializeField] private Image imageCurriculo;
    [SerializeField] private TextMeshProUGUI namePersonagem;
    [SerializeField] private TextMeshProUGUI cargoText;

    private void Start()
    {
        if (SistemaDeSeleção.GetInstance().pessoaAtual.imagemPessoa != null)
        {
            imageCurriculo.sprite = SistemaDeSeleção.GetInstance().pessoaAtual.imagemPessoa;
        }
        namePersonagem.text = SistemaDeSeleção.GetInstance().pessoaAtual.GetNomeCompleto();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            SistemaDeSeleção.GetInstance().MudarIndiceNext();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            SistemaDeSeleção.GetInstance().MudarIndicePrevious();
        }
        if (SistemaDeSeleção.GetInstance().indice == 0)
        {
            cargoText.text = "Cargo: Desenvolvedor";
        }
        else if (SistemaDeSeleção.GetInstance().indice == 1)
        {
            cargoText.text = "Cargo: Produtor Executivo";
        }
        else if (SistemaDeSeleção.GetInstance().indice == 2)
        {
            cargoText.text = "Cargo: Desenvolvedor";
        }
        else if (SistemaDeSeleção.GetInstance().indice == 3)
        {
            cargoText.text = "Cargo: Designer";
        }
        else if (SistemaDeSeleção.GetInstance().indice == 4)
        {
            cargoText.text = "Cargo: Produtor Executivo";
        }
        else if (SistemaDeSeleção.GetInstance().indice == 5)
        {
            cargoText.text = "Cargo: Designer";
        }
    }

    public void SetImageCurriculo(Sprite spr)
    {
        imageCurriculo.sprite = spr;
    }
    public void SetNamePersonagem(string nome)
    {
        namePersonagem.text = nome;
    }

}
