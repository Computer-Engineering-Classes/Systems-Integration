options = ["notepad", "wordpad"]
s = select("Escolha a que prefere abrir:", options=options)
wait(0.5)
type(Key.WIN)
wait(0.5)
type(s + Key.ENTER)
wait(1)
if s == "notepad":
    type("Notepad apenas permite escrever texto simples!")
else:
    type("Com o Wordpad consigo formatar o texto!")

wait(0.5)
type("g", Key.CTRL)

wait(0.5)
type("Ficheiro+" + s)
type(Key.ENTER)    

wait(0.5)
type(Key.F4, Key.ALT)
    