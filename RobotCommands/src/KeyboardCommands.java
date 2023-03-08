import java.awt.*;
import java.awt.event.KeyEvent;
import java.util.Map;

/**
 * <p>
 * This class contains methods for controlling the keyboard
 * (e.g. press key, type string, etc.)
 * <p>
 * <b>NOTE:</b> This class requires the Java Robot class
 * <p>
 * <b>Example:</b>
 * <pre>
 *     Robot robot = new Robot();
 *     KeyboardCommands.typeString(robot, "Hello World!");
 *     KeyboardCommands.selectAll(robot);
 *     KeyboardCommands.copy(robot);
 *     KeyboardCommands.pressKey(robot, KeyEvent.VK_ENTER);
 *     KeyboardCommands.paste(robot);
 *     KeyboardCommands.save(robot);
 * </pre>
 */
@SuppressWarnings("unused")
public class KeyboardCommands {
    private static final Map<Character, Integer> altGrKeyMap = Map.ofEntries(
            Map.entry('@', KeyEvent.VK_2),
            Map.entry('£', KeyEvent.VK_3),
            Map.entry('§', KeyEvent.VK_4),
            Map.entry('{', KeyEvent.VK_7),
            Map.entry('[', KeyEvent.VK_8),
            Map.entry(']', KeyEvent.VK_9),
            Map.entry('}', KeyEvent.VK_0)
    );

    private static final Map<Character, Integer> shiftKeyMap = Map.ofEntries(
            Map.entry('|', KeyEvent.VK_BACK_SLASH),
            Map.entry('!', KeyEvent.VK_1),
            Map.entry('"', KeyEvent.VK_2),
            Map.entry('#', KeyEvent.VK_3),
            Map.entry('$', KeyEvent.VK_4),
            Map.entry('%', KeyEvent.VK_5),
            Map.entry('&', KeyEvent.VK_6),
            Map.entry('/', KeyEvent.VK_7),
            Map.entry('(', KeyEvent.VK_8),
            Map.entry(')', KeyEvent.VK_9),
            Map.entry('=', KeyEvent.VK_0),
            Map.entry('?', KeyEvent.VK_QUOTE),
            Map.entry('^', KeyEvent.VK_DEAD_TILDE),
            Map.entry(';', KeyEvent.VK_COMMA),
            Map.entry(':', KeyEvent.VK_PERIOD),
            Map.entry('_', KeyEvent.VK_MINUS)
    );

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
        if (shiftKeyMap.containsKey(c) || Character.isUpperCase(c)) {
            typeShiftCharacter(robot, c);
        } else if (altGrKeyMap.containsKey(c)) {
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
        int keyCode = altGrKeyMap.getOrDefault(c, KeyEvent.VK_UNDEFINED);
        pressKey(robot, keyCode);
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
        int keyCode = shiftKeyMap.getOrDefault(c, KeyEvent.VK_UNDEFINED);
        pressKey(robot, keyCode);
        robot.keyRelease(KeyEvent.VK_SHIFT);
        if (c == '^') {
            pressKey(robot, KeyEvent.VK_SPACE);
        }
    }
}
