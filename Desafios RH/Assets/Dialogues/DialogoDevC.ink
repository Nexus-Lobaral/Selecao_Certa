-> main
VAR nomePersonagem = ""
VAR nomeJogador = ""
VAR vez = 0 // se for 0 é o jogador, se for 1 é o personagem
VAR qntErros = 2
=== main ===
~ vez = 0
Ola {nomePersonagem}, prazer, meu nome é {nomeJogador}, podemos começar a entrevista?
~ vez = 1
Certo.
~ vez = 0
Por que você escolheu nossa empresa?
~ vez = 1
Eu escolhi esta empresa justamente porque ela trabalha com o tipo de jogo que eu gosto de desenvolver.
-> escolhas1
=== escolhas1 ===
~ vez = 0
Escolha uma opção:
    * [Voce tem repertorio sobre a cultura Mexicana?]
        Você errou a resposta pois esta opção muda de assunto muito rapidamente.
        ~ qntErros -= 1
        -> escolhas1
        
    * [Hum, interessante. Mas você escolheu somente por causa disso ou tem mais algum outro interesse?] // CERTA RESPOSTA
        Muito bem, certa resposta!!!
        -> main2
    * [Qual é esse tipo de jogo que você se refere?]
        Você meio que já devia saber o tipo de jogo que sua empressa irá desenvolver
        ~ qntErros -= 1
        -> escolhas1
=== main2 ===
~ vez = 1
Porque é uma empresa que esta em constante crescimento e eu quero fazer parte disso.
~ vez = 0
Então você vê potencial na nossa empresa?
~ vez = 1
Sim, eu vejo bastante potencial e sinto que vou me estabelecer bem nesta empresa.
-> escolhas2
=== escolhas2 ===
~ vez = 0
Escolha uma opção:
    * [Certo. Você tem algum problema com comunicação em equipe?] // CERTA RESPOSTA
        Muito bem, certa resposta!!!
        -> main3
    * [Você cursou alguma faculdade de Tecnologia?]
        Errado pois isso ja deve esta escrito no curriculo.
        ~ qntErros -= 1
        -> escolhas2
    * [Beleza então. Qual sua cor favorita?]
        Preciso falar o porquê essa esta errada?
        ~ qntErros -= 1
        -> escolhas2
=== main3 ===
~ vez = 1
Eu consigo falar sobre o projeto sem ter qualquer tipo de medo ou ansiedade, mas somente de forma profissional.
~ vez = 0
Certo....Bom encerramos por aqui se tivermos mensagens lhe enviaremos


    - -> END // DE qualquer forma ele termina o dialogo