package com.filehashconfirm;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.stage.Stage;

public class Main extends Application {

    /**
     * @param primaryStage
     * @throws Exception
     */
    @Override
    public void start(Stage primaryStage) throws Exception{
        Parent root = FXMLLoader.load(getClass().getResource("AppForm.fxml"));
        primaryStage.setTitle("FileHashConfirm");
        primaryStage.setResizable(false);
        primaryStage.getIcons().add(new Image(getClass().getResourceAsStream("resources/app_logo.png")));
        primaryStage.setScene(new Scene(root, 400, 477));
        primaryStage.show();
    }


    /**
     * Program Entry point
     * @param args
     */
    public static void main(String[] args) {
        launch(args);
    }

}
