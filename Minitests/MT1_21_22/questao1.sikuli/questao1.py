s = input("Notepad ou Wordpad?")
s = s.lower()
if s in ["notepad", "wordpad"]: 
    type(Key.WIN)
    wait(0.5)
    type(s + Key.ENTER)
    wait(0.5)
    if s == "notepad":
        type("Notepad apenas permite escrever texto simples!")
    else:
        type("Com o Wordpad consigo formatar o texto!")
    
    wait(0.3)
    type("g", Key.CTRL)
    
    wait(0.3)
    type("Ficheiro+" + s)
    type(Key.ENTER)    
    
    wait(0.5)
    type(Key.F4, Key.ALT)
    