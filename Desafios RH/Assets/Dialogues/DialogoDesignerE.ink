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
....
~ vez = 0
Podemos começar?
~ vez = 1
Ah, sim, sim, pode.
-> escolhas1
=== escolhas1 ===
~ vez = 0
Escolha uma opção:
    * [Como é sua comunicação com pessoas?]
        Muito bem, certa resposta!!!
        -> main2
    * [Você tem algum problema!?]// CERTA RESPOSTA
        O jeito de sua fala é muito importante na hora de fazer perguntas
        ~ qntErros -= 1
        -> escolhas1
    * [Não precisa ficar nervoso]
        Ele não parece nervoso, apenas distraído
        ~ qntErros -= 1
        -> escolhas1
=== main2 ===
~ vez = 1
Ah, eu sou bem comunicativo, mas, como pode ver, sou muito distraído.
-> escolhas2
=== escolhas2 ===
~ vez = 0
Escolha uma opção:
    * [O quanto distraído você é?]
        Ele já falou que é muito distraído... e parece que você também
        ~ qntErros -= 1
        -> escolhas2
    * [Você sabe se é uma condição tipo déficit ou algo do gênero?]
        Muito bem, certa resposta!!!
        -> main3
    * [Que coisa, não?]
        Pergunte algo que gere mais informações, para entender o tipo de pessoa que ele é
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
        Não, ele não podia, pois é algo em descobrimento com certas dúvidas
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
(Pensamento: Ele pareceu muito nervoso com essa pergunta...)
Entendi, vou analisar aqui e ja te dou a resposta se vamos te contratar.
    * [Contratar]
        ~ contratado = 1
        Parabens, Acabei de decidir que vamos te contratar
    * [Rejeitar]
        ~ contratado = 0
        Infelizmente vou te rejeitar, tente na proxima

    - -> END // DE qualquer forma ele termina o dialogo