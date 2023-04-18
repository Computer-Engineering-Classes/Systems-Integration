# Notes

## SikuliX Notes

### Mouse

- click() - left click
- rightClick() - right click
- doubleClick() - double click

### Keyboard

- type(string) - type string
- type(Key.ENTER) - press enter

### Controls

- wait() - wait for a second
- wait(2) - wait for 2 seconds
- sleep(2.5) - sleep for 2.5 seconds

## Robot Notes

### Mouse Commands

- mouseMove(x, y) - move mouse to x, y
- mousePress(Keycode.VK_A) - press A
- mouseRelease(Keycode.VK_A) - release A
- mouseWheel(1) - scroll up

### Keyboard Commands

- keyPress(Keycode.VK_A) - press A
- keyRelease(Keycode.VK_A) - release A

### Control Commands

- delay(1000) - delay for 1 second

## REST API Notes

### GET

```bash
curl -X GET https://localhost:8080/api/v1/notes
```

### POST

```bash
curl -X POST https://localhost:8080/api/v1/notes -H `Content-Type: application/json' -d '{"title":"test","content":"test"}`
```

### PUT

```bash
curl -X PUT https://localhost:8080/api/v1/notes/1 -H `Content-Type: application/json' -d '{"title":"test","content":"test"}`
```

### DELETE

```bash
curl -X DELETE https://localhost:8080/api/v1/notes/1
```

## DBMS Notes

### DB Creation

- CREATE DATABASE Livros;

### Table Creation

- CREATE TABLE Livros (. . .);

### Stored Procedure Creation

```sql
CREATE PROCEDURE InsertLivro (@titulo varchar(50), @autor varchar(50), @editora varchar(50), @ano int) AS 
    BEGIN 
        INSERT INTO Livros (Titulo, Autor, Editora, Ano) 
        VALUES (@titulo, @autor, @editora, @ano) 
    END
```

## Message-Oriented Middleware (MoM) Notes

### RabbitMQ

- Hello World: The "Hello World!" tutorial is the "Hello World!" of RabbitMQ. It shows how to send and receive a message. [RabbitMQ](https://www.rabbitmq.com/tutorials/tutorial-one-csharp.html)

- Work Queues: A common way to parallelize computationally intensive tasks is to distribute the individual tasks among multiple workers. This is called the "work queue" pattern. [RabbitMQ](https://www.rabbitmq.com/tutorials/tutorial-two-csharp.html)

- Publish/Subscribe: Publish/Subscribe is a messaging pattern where senders of messages, called publishers, do not program the messages to be sent directly to specific receivers, called subscribers. Instead, published messages are characterized into classes without knowledge of which subscribers, if any, there may be. Similarly, subscribers express interest in one or more classes and only receive messages that are of interest, without knowledge of which publishers, if any, there are. [RabbitMQ](https://www.rabbitmq.com/tutorials/tutorial-three-csharp.html)

## Java Native Interface

-- Criar Header File e Class File
javac -h "*Diretoria da pasta*" HelloJNI.java

-- Criar biblioteca .dll a partir do gcc
gcc -I "C:\Users\diogo\.jdks\openjdk-20\include" -I "C:\Users\diogo\.jdks\openjdk-20\include\win32" -shared -o hello.dll HelloJNI.c

-- Executar programa
java -classpath "*Diretoria da pasta*" HelloJNI
