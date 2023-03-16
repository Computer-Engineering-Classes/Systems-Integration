# Notes

## SikuliX Notes

### Mouse

- click() - left click
- rightClick() - right click
- doubleClick() - double click

### Keyboard

- type(string) - type string
- type(Key.ENTER) - press enter

### Control

- wait() - wait for a second
- wait(2) - wait for 2 seconds
- sleep(2.5) - sleep for 2.5 seconds

## Robot Notes

### Mouse

- mouseMove(x, y) - move mouse to x, y
- mousePress(Keycode.VK_A) - press A
- mouseRelease(Keycode.VK_A) - release A
- mouseWheel(1) - scroll up

### Keyboard

- keyPress(Keycode.VK_A) - press A
- keyRelease(Keycode.VK_A) - release A

### Control

- delay(1000) - delay for 1 second

## REST API Notes

### GET

- curl -X GET http://localhost:8080/api/v1/notes

### POST

- curl -X POST http://localhost:8080/api/v1/notes -H `Content-Type: application/json' -d '{"title":"test","content":"test"}`

### PUT

- curl -X PUT http://localhost:8080/api/v1/notes/1 -H `Content-Type: application/json' -d '{"title":"test","content":"test"}`

### DELETE

- curl -X DELETE http://localhost:8080/api/v1/notes/1