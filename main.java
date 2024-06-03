import javax.swing.*;

public class MainWindow extends JFrame {
    public MainWindow() {
        setTitle("My Window");
        setSize(400, 300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        JLabel label = new JLabel("Hello, Java!");
        getContentPane().add(label);
        setVisible(true);
    }

    public static void main(String[] args) {
        new MainWindow();
    }
}

