import java.awt.*;
import java.awt.event.InputEvent;

/**
 * <p>
 * This class contains methods for controlling the mouse
 * (e.g. left click, right click, move, etc.)
 * <p>
 * <b>NOTE:</b> This class requires the Java Robot class
 * <p>
 * <b>Example:</b>
 * <pre>
 *         Robot robot = new Robot();
 *         MouseCommands.clickAt(robot, 100, 200);
 *         MouseCommands.rightClick(robot);
 *         MouseCommands.move(robot, 100, 200);
 *         MouseCommands.scroll(robot, 10);
 * </pre>
 * <p>
 */
@SuppressWarnings("unused")
public class MouseCommands {
    /**
     * Gets the current mouse position (x, y) in pixels
     *
     * @return Position object containing the current mouse position
     */
    public static Position getLocation() {
        PointerInfo pointer = MouseInfo.getPointerInfo();
        Point point = pointer.getLocation();
        int x = (int) point.getX();
        int y = (int) point.getY();
        return new Position(x, y);
    }

    /**
     * Left clicks at the specified coordinates (x, y) (e.g. 100, 200)
     *
     * @param robot Robot
     * @param x     X coordinate
     * @param y     Y coordinate
     */
    public static void clickAt(Robot robot, int x, int y) {
        robot.mouseMove(x, y);
        leftClick(robot);
    }

    /**
     * Left clicks at the current mouse position
     *
     * @param robot Robot
     */
    public static void leftClick(Robot robot) {
        robot.mousePress(InputEvent.BUTTON1_DOWN_MASK);
        robot.mouseRelease(InputEvent.BUTTON1_DOWN_MASK);
    }

    /**
     * Drags an icon from one position to another
     *
     * @param robot   Robot
     * @param x_start X coordinate of the start position
     * @param y_start Y coordinate of the start position
     * @param x_end   X coordinate of the end position
     * @param y_end   Y coordinate of the end position
     */
    public static void dragIcon(Robot robot, int x_start, int y_start, int x_end, int y_end) {
        robot.mouseMove(x_start, y_start);
        robot.mousePress(InputEvent.BUTTON1_DOWN_MASK);
        robot.mouseMove(x_end, y_end);
        robot.mouseRelease(InputEvent.BUTTON1_DOWN_MASK);
    }

    /**
     * Double-clicks at the current mouse position
     *
     * @param robot Robot
     */
    public static void doubleClick(Robot robot) {
        leftClick(robot);
        leftClick(robot);
    }

    /**
     * Right-clicks at the current mouse position
     *
     * @param robot Robot
     */
    public static void rightClick(Robot robot) {
        robot.mousePress(InputEvent.BUTTON3_DOWN_MASK);
        robot.mouseRelease(InputEvent.BUTTON3_DOWN_MASK);
    }

    /**
     * Mouse pointer position (x, y)
     *
     * @param x X coordinate
     * @param y Y coordinate
     */
    private record Position(int x, int y) {
        @Override
        public String toString() {
            return "(" + x + ", " + y + ")";
        }
    }
}