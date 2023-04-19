import java.util.Random;

public class RhythmCalculator {
    static {
        System.loadLibrary("RhythmCalculator");
    }

    public static void main(String[] args) {
        final int control_posts = 10;
        // Create arrays for times and distances
        float[] times = new float[control_posts];
        float[] distances = new float[control_posts];
        // Generate random times and distances
        Random random = new Random();
        for (int i = 0; i < control_posts; i++) {
            times[i] = random.nextFloat(10);
            distances[i] = random.nextFloat(1000);
        }
        // Calculate the rhythm
        RhythmCalculator rhythmCalculator = new RhythmCalculator();
        var rhythm = rhythmCalculator.getRhythm(times, distances);
        // Print the rhythm
        System.out.println("Rhythm: " + rhythm + " min/m");
    }

    private native float getRhythm(float[] times, float[] distances);
}
