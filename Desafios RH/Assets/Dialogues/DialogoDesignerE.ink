-> main
VAR nomePersonagem = ""
VAR nomeJogador = ""
VAR vez = 0 // se for 0 é o jogador, se for 1 é o personagem
VAR qntErros = 2
=== main ===
~ vez = 0
Ola {nomePersonagem}, prazer, meu nome é {nomeJogador}, podemos começar a entrevista?
~ vez = 1
....
~ vez = 0
Podemos começar?
~ vez = 1
Ah, sim, sim, pode.
-> escolhas1
=== escolhas1 ===
~ vez = 0
Escolha uma opção:
    * [Como é sua comunicação com pessoas?] //CERTA RESPOSTA
        Muito bem, certa resposta!!!
        -> main2
    * [Você tem algum problema!?]
        O jeito de sua fala é muito importante na hora de fazer perguntas
        ~ qntErros -= 1
        -> escolhas1
    * [Não precisa ficar nervoso]
        Ela não parece nervoso, apenas distraído
        ~ qntErros -= 1
        -> escolhas1
=== main2 ===
~ vez = 1
Ah, eu sou bem comunicativa, mas, como pode ver, sou muito distraída.
-> escolhas2
=== escolhas2 ===
~ vez = 0
Escolha uma opção:
    * [O quanto distraída você é?]
        Ela já falou que é muito distraída... e parece que você também
        ~ qntErros -= 1
        -> escolhas2
    * [Você sabe se é uma condição tipo déficit ou algo do gênero?]
        Muito bem, certa resposta!!!
        -> main3
    * [Que coisa, não?]
        Pergunte algo que gere mais informações, para entender o tipo de pessoa que ela é
        ~ qntErros -= 1
        -> escolhas2
=== main3 ===
~ vez = 1
Disso eu ainda não tenho certeza, pois ainda estou fazendo exames.
~ vez = 0
Compreensível.
-> escolhas3
=== escolhas3 ===
Escolha uma opção:
    * [Mas alguma vez você teve um grande problema com sua distração?]// CERTA RESPOSTA
        Certa Resposta!
        -> main4
    * [Você poderia ter falado isso antes.]
        Não, ela não podia, pois é algo em descobrimento com certas dúvidas
        ~ qntErros -= 1
        -> escolhas3
    * [Mas no momento, qual tipo de transtorno você acha que tem?]
        Autoavaliação de uma doença mental não funciona, além de que o diagnóstico ainda será feito
        ~ qntErros -= 1
        -> escolhas3
=== main4 ===
~ vez = 1
B-bom, eu nunca tive um problema desses. (Voz trêmula)
~ vez = 0
(Pensamento: Ela pareceu muito nervosa com essa pergunta...)
Entendi, vou te ligar se tivermos notícias

    - -> END // DE qualquer forma ele termina o dialogo