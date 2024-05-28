-> main
VAR nomePersonagem = ""
VAR nomeJogador = ""
VAR vez = 0 // se for 0 é o jogador, se for 1 é o personagem
VAR contratado = 0 // 1 igual a contratado e 0 igual a rejeitado
VAR qntErros = 2
=== main ===
~ vez = 0
Ola {nomePersonagem}, prazer, meu nome é {nomeJogador}, podemos começar a entrevista?
~ vez = 1
C-certo.
-> escolhas1
=== escolhas1 ===
~ vez = 0
Escolha uma opção:
    * [Você está bem?]
        Ele so tremeu na fala, calma, não é como se ele tivesse devendo pro agiota
        ~ qntErros -= 1
        -> escolhas1
    * [O que te fez se interessa pela nossa vaga?]// CERTA RESPOSTA
        Muito bem, certa resposta!!!
        -> main2
    * [Porquê você está tremendo? Ta com medo?]
        Cara bullynar e entrevistar são um pouco diferentes
        ~ qntErros -= 1
        -> escolhas1
=== main2 ===
~ vez = 1
B-bom eu queria me descobrir em uma area que eu gosto
-> escolhas2
=== escolhas2 ===
~ vez = 0
Escolha uma opção:
    * [Como você quer se descobrir?]// CERTA RESPOSTA
        Se descobrir é meio auto explicavel
        ~ qntErros -= 1
        -> escolhas2
    * [Como assim que você gosta?]
        Muito bem, certa resposta!!!
        -> main3
    * [Então você não tem nenhum tipo de experiencia com essa area?]
        Já foi mostrado no seu curriculo
        ~ qntErros -= 1
        -> escolhas2
=== main3 ===
~ vez = 1
É que eu sempre queria ser responsavel pelo trabalho de gerenciamento
~ vez = 0
Certo.
-> escolhas3
=== escolhas3 ===
Escolha uma opção:
    * [Você consegue interagir com pessoas facilmente?]// CERTA RESPOSTA
        Muito bem, certa resposta!!!
        -> main4
    * [Como você faria em um gerenciamento?]
        Não a necessidade de perguntar isso
        ~ qntErros -= 1
        -> escolhas3
    * [Então você já tem noção desse trabalho?]
        Ele já disse que quer se descobrir ou seja ainda está em desenvolvimento
        ~ qntErros -= 1
        -> escolhas3
=== main4 ===
~ vez = 1
Sendo sincero não
~ vez = 0
Entendi, vou analisar aqui e ja te dou a resposta se vamos te contratar.

    * [Contratar]
        ~ contratado = 1
        Parabens, Acabei de decidir que vamos te contratar
    * [Rejeitar]
        ~ contratado = 0
        Infelizmente vou te rejeitar, tente na proxima

    - -> END // DE qualquer forma ele termina o dialogo