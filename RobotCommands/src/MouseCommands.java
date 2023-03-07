import java.awt.*;
import java.awt.event.InputEvent;

@SuppressWarnings("unused")
public class MouseCommands {
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
     * Gets the current mouse position
     */
    public static void getLocation() {
        PointerInfo pointer = MouseInfo.getPointerInfo();
        Point point = pointer.getLocation();
        int x = (int) point.getX();
        int y = (int) point.getY();
        System.out.println(x + "," + y);
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
}