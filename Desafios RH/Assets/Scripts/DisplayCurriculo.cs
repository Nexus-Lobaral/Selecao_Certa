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
        if (SistemaDeSele��o.GetInstance().pessoaAtual.imagemPessoa != null)
        {
            imageCurriculo.sprite = SistemaDeSele��o.GetInstance().pessoaAtual.imagemPessoa;
        }
        namePersonagem.text = SistemaDeSele��o.GetInstance().pessoaAtual.GetNomeCompleto();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            SistemaDeSele��o.GetInstance().MudarIndiceNext();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            SistemaDeSele��o.GetInstance().MudarIndicePrevious();
        }
        if (SistemaDeSele��o.GetInstance().indice == 0)
        {
            cargoText.text = "Cargo: Desenvolvedor";
        }
        else if (SistemaDeSele��o.GetInstance().indice == 1)
        {
            cargoText.text = "Cargo: Produtor Executivo";
        }
        else if (SistemaDeSele��o.GetInstance().indice == 2)
        {
            cargoText.text = "Cargo: Desenvolvedor";
        }
        else if (SistemaDeSele��o.GetInstance().indice == 3)
        {
            cargoText.text = "Cargo: Designer";
        }
        else if (SistemaDeSele��o.GetInstance().indice == 4)
        {
            cargoText.text = "Cargo: Produtor Executivo";
        }
        else if (SistemaDeSele��o.GetInstance().indice == 5)
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
