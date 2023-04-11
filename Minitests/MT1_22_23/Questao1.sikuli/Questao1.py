options = ["browser", "notepad"]
option = select("Selecione a opcao:", options=options)
wait(0.5)

if option == "browser":
    s = input("Texto a pesquisar:")
    wait(0.5)
    type(Key.WIN)
    wait(0.5)
    type("opera" + Key.ENTER)
    wait(2)
    type(s + Key.ENTER)
elif option == "notepad":
    type(Key.WIN)
    wait(0.5)
    type(option + Key.ENTER)
    wait(0.5)
    for i in range(1, 6):
        type("Hello world " + str(i) + Key.ENTER)