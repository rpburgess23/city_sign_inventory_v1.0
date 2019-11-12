package sample;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
import javafx.scene.control.Label;
import javafx.geometry.Pos;

public class Main extends Application {

    @Override
    public void start(Stage primaryStage) throws Exception{
        Parent root = FXMLLoader.load(getClass().getResource("sample.fxml"));
        primaryStage.setTitle("City Sign Inventory Management");
        primaryStage.setScene(new Scene(root, 1000, 875));
        Label label = new Label("Welcome to the City Sign Inventory Management App");
        label.setAlignment(Pos.CENTER);

        primaryStage.show();
    }


    public static void main(String[] args) {
        launch(args);
    }

}
