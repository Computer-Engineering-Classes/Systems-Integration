import java.awt.*;
import java.awt.event.KeyEvent;

@SuppressWarnings("unused")
public class KeyboardCommands {
    /**
     * Presses the specified key and releases it
     *
     * @param robot Robot
     * @param key   Key to press (e.g. KeyEvent.VK_ENTER)
     */
    public static void pressKey(Robot robot, int key) {
        robot.keyPress(key);
        robot.keyRelease(key);
    }

    /**
     * Pastes text from the clipboard (CTRL + V)
     *
     * @param robot Robot
     */
    public static void copy(Robot robot) {
        robot.keyPress(KeyEvent.VK_CONTROL);
        robot.keyPress(KeyEvent.VK_C);
        robot.keyRelease(KeyEvent.VK_C);
        robot.keyRelease(KeyEvent.VK_CONTROL);
    }

    /**
     * Pastes text from the clipboard (CTRL + V)
     *
     * @param robot Robot
     */
    public static void paste(Robot robot) {
        robot.keyPress(KeyEvent.VK_CONTROL);
        robot.keyPress(KeyEvent.VK_V);
        robot.keyRelease(KeyEvent.VK_V);
        robot.keyRelease(KeyEvent.VK_CONTROL);
    }

    /**
     * Cuts the selected text in the current window (CTRL + X)
     *
     * @param robot Robot
     */
    public static void cut(Robot robot) {
        robot.keyPress(KeyEvent.VK_CONTROL);
        robot.keyPress(KeyEvent.VK_X);
        robot.keyRelease(KeyEvent.VK_X);
        robot.keyRelease(KeyEvent.VK_CONTROL);
    }

    /**
     * Selects all text in the current window (CTRL + A)
     *
     * @param robot Robot
     */
    public static void selectAll(Robot robot) {
        robot.keyPress(KeyEvent.VK_CONTROL);
        robot.keyPress(KeyEvent.VK_A);
        robot.keyRelease(KeyEvent.VK_A);
        robot.keyRelease(KeyEvent.VK_CONTROL);
    }

    /**
     * Saves the current file (CTRL + S)
     *
     * @param robot Robot
     */
    public static void save(Robot robot) {
        robot.keyPress(KeyEvent.VK_CONTROL);
        robot.keyPress(KeyEvent.VK_S);
        robot.keyRelease(KeyEvent.VK_S);
        robot.keyRelease(KeyEvent.VK_CONTROL);
    }

    /**
     * Types a string using the keyboard (e.g. "Hello World!")
     *
     * @param robot Robot
     * @param str   String to type
     */
    public static void typeString(Robot robot, String str) {
        robot.setAutoDelay(50);
        for (int i = 0; i < str.length(); i++) {
            char c = str.charAt(i);
            typeCharacter(robot, c);
        }
    }

    /**
     * Types a character using the keyboard (e.g. 'a')
     *
     * @param robot Robot
     * @param c     Character to type
     */
    public static void typeCharacter(Robot robot, char c) {
        String altGrChars = "@£§{[]}";
        String shiftChars = "|!\"#$%&/()=?»*`ª;:_>";
        if (shiftChars.contains(String.valueOf(c)) || Character.isUpperCase(c)) {
            typeShiftCharacter(robot, c);
        } else if (altGrChars.contains(String.valueOf(c))) {
            typeAltGrCharacter(robot, c);
        } else {
            typeStandardCharacter(robot, c);
        }
    }

    /**
     * Types a character that requires the AltGr key to be pressed (e.g. '@£§{[]}')
     *
     * @param robot Robot
     * @param c     Character to type
     */
    private static void typeAltGrCharacter(Robot robot, char c) {
        robot.keyPress(KeyEvent.VK_ALT_GRAPH);
        switch (c) {
            case '@' -> pressKey(robot, KeyEvent.VK_2);
            case '£' -> pressKey(robot, KeyEvent.VK_3);
            case '§' -> pressKey(robot, KeyEvent.VK_5);
            case '{' -> pressKey(robot, KeyEvent.VK_7);
            case '[' -> pressKey(robot, KeyEvent.VK_8);
            case ']' -> pressKey(robot, KeyEvent.VK_9);
            case '}' -> pressKey(robot, KeyEvent.VK_0);
        }
        robot.keyRelease(KeyEvent.VK_ALT_GRAPH);
    }

    /**
     * Types a standard character (e.g. 'a') using the keyboard
     *
     * @param robot Robot
     * @param c     Character to type
     */
    private static void typeStandardCharacter(Robot robot, char c) {
        int keyCode = KeyEvent.getExtendedKeyCodeForChar(c);
        if (keyCode == KeyEvent.VK_UNDEFINED) {
            throw new IllegalArgumentException("Cannot type character " + c);
        }
        pressKey(robot, keyCode);
    }

    /**
     * Types a character that requires the Shift key to be pressed (e.g. '!#$%&/()' or 'A-Z')
     *
     * @param robot Robot
     * @param c     Character to type
     */
    private static void typeShiftCharacter(Robot robot, char c) {
        robot.keyPress(KeyEvent.VK_SHIFT);
        if (Character.isUpperCase(c)) typeStandardCharacter(robot, c);
        else switch (c) {
            case '|' -> pressKey(robot, KeyEvent.VK_BACK_SLASH);
            case '!' -> pressKey(robot, KeyEvent.VK_1);
            case '"' -> pressKey(robot, KeyEvent.VK_2);
            case '#' -> pressKey(robot, KeyEvent.VK_3);
            case '$' -> pressKey(robot, KeyEvent.VK_4);
            case '%' -> pressKey(robot, KeyEvent.VK_5);
            case '&' -> pressKey(robot, KeyEvent.VK_6);
            case '/' -> pressKey(robot, KeyEvent.VK_7);
            case '(' -> pressKey(robot, KeyEvent.VK_8);
            case ')' -> pressKey(robot, KeyEvent.VK_9);
            case '=' -> pressKey(robot, KeyEvent.VK_0);
            case '?' -> pressKey(robot, KeyEvent.VK_QUOTE);
            case '_' -> pressKey(robot, KeyEvent.VK_MINUS);
            case ':' -> pressKey(robot, KeyEvent.VK_PERIOD);
            case '^' -> pressKey(robot, KeyEvent.VK_DEAD_TILDE);
        }
        robot.keyRelease(KeyEvent.VK_SHIFT);
        if (c == '^') {
            pressKey(robot, KeyEvent.VK_SPACE);
        }
    }
}
