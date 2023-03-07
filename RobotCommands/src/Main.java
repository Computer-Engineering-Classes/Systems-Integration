import java.awt.*;
import java.awt.event.KeyEvent;

@SuppressWarnings("unused")
public class Main {
    public static void main(String[] args) {
        //noinspection CommentedOutCode
        try {
            Robot robot = new Robot();
            openAndWriteInNotepad(robot);
            // fillInForm(robot);
            // loginToSIDE(robot);
            // postOnDiscord(robot);
        } catch (AWTException e) {
            System.err.println("Error: " + e.getMessage());
        }
    }

    public static void openAndWriteInNotepad(Robot robot) {
        // Open search bar
        KeyboardCommands.pressKey(robot, KeyEvent.VK_WINDOWS);
        robot.delay(1000);
        // Type "notepad" and press enter
        KeyboardCommands.typeString(robot, "notepad");
        KeyboardCommands.pressKey(robot, KeyEvent.VK_ENTER);
        robot.delay(1000);
        // Type "Hello world"
        KeyboardCommands.typeString(robot, "Hello world!");
    }

    public static void fillInForm(Robot robot) {
        // Click on the form
        MouseCommands.clickAt(robot, 50, 100);
        robot.delay(1000);
        // Type student number (backspace is needed because the form is already filled)
        KeyboardCommands.pressKey(robot, KeyEvent.VK_BACK_SPACE);
        KeyboardCommands.typeString(robot, "70579");
        KeyboardCommands.pressKey(robot, KeyEvent.VK_TAB);
        // Type name and email
        KeyboardCommands.typeString(robot, "Joao Rodrigues");
        KeyboardCommands.pressKey(robot, KeyEvent.VK_TAB);
        KeyboardCommands.typeString(robot, "al70579@alunos.utad.pt");
        KeyboardCommands.pressKey(robot, KeyEvent.VK_TAB);
        KeyboardCommands.pressKey(robot, KeyEvent.VK_ENTER);
    }

    public static void loginToSIDE(Robot robot) {
        // Open search bar
        KeyboardCommands.pressKey(robot, KeyEvent.VK_WINDOWS);
        robot.delay(1000);
        // Type "side.utad.pt" and press enter
        KeyboardCommands.typeString(robot, "side.utad.pt");
        KeyboardCommands.pressKey(robot, KeyEvent.VK_ENTER);
        robot.delay(1500);
        // Click on "Login"
        MouseCommands.clickAt(robot, 930, 175);
        robot.delay(1500);
        // Type username and password
        KeyboardCommands.typeString(robot, "al70633");
        KeyboardCommands.pressKey(robot, KeyEvent.VK_TAB);
        KeyboardCommands.typeString(robot, "password123");
        KeyboardCommands.pressKey(robot, KeyEvent.VK_ENTER);
    }

    public static void postOnDiscord(Robot robot) {
        // Open search bar
        KeyboardCommands.pressKey(robot, KeyEvent.VK_WINDOWS);
        robot.delay(1000);
        // Type "discord" and press enter
        KeyboardCommands.typeString(robot, "discord");
        KeyboardCommands.pressKey(robot, KeyEvent.VK_ENTER);
        robot.delay(1500);
        // Click on server icon
        MouseCommands.clickAt(robot, 37, 330);
        // Click on channel
        MouseCommands.clickAt(robot, 139, 405);
        // Type message
        KeyboardCommands.typeString(robot, "Hello world!");
        KeyboardCommands.pressKey(robot, KeyEvent.VK_ENTER);
    }
}