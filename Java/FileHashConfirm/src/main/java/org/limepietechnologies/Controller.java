package org.limepietechnologies;

import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.ButtonType;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.input.DragEvent;
import javafx.scene.input.TransferMode;
import javafx.scene.layout.Pane;

import java.io.File;
import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

public class Controller implements Initializable {
    //GUI Elements
    public Label dropZoneLabel;
    public Pane dropZone;
    public TextField givenHashTextBox;
    public TextField md5HashTextBox;
    public TextField sha1HashTextBox;
    public TextField sha256HashTextBox;
    public ImageView appLogo;
    public ImageView statusIconMD5;
    public ImageView statusIconSHA1;
    public ImageView statusIconSHA256;
    //Class Attributes
    private String[] hashes = new String[]{"","",""};
    private final int MD5_LENGTH = 32;
    private final int SHA1_LENGTH = 40;
    private final int SHA256_LENGTH = 64;
    private TextField[] textFields;
    private ImageView[] imageViews;
    private Image check;
    private Image cancel;


    /**
     * The class Initializer implemented from the Initializable
     * interface.
     * @param url
     * @param resourceBundle
     */
    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        appLogo.setImage(new Image(App.class.getResourceAsStream("app_logo.png")));
        check = new Image(App.class.getResourceAsStream("tick.png"));
        cancel = new Image(App.class.getResourceAsStream("cancel.png"));
        textFields = new TextField[]{md5HashTextBox,sha1HashTextBox,sha256HashTextBox};
        imageViews = new ImageView[]{statusIconMD5,statusIconSHA1,statusIconSHA256};
        givenHashTextBox.textProperty().addListener(new ChangeListener<String>() {
            @Override
            public void changed(ObservableValue<? extends String> observableValue, String s, String t1) {
                if(checkForHashes()){
                    reset(false);
                    makeComparisons();
                }
            }
        });
    }

    /**
     * A handler for the drag dropped event
     * @param dragEvent
     */
    public void onFileDrop(DragEvent dragEvent) {
        File file = dragEvent.getDragboard().getFiles().get(0);
        if(file.isFile()){
            try {
                hashes = HashingMachine.getFileChecksum(file);
                processHashes();
                dropZoneLabel.setText("Drag and Drop File Here.");
            }catch (IOException exception){
                showError("There was an error reading the file");
            }
        }else{
            showError("Only Files Allowed.");
        }
        dragEvent.setDropCompleted(true);
        dragEvent.consume();
    }

    /**
     * A handler for the drag over event
     * @param dragEvent
     */
    public void onFileDragOver(DragEvent dragEvent) {
        if(dragEvent.getDragboard().hasFiles()) {
            dragEvent.acceptTransferModes(TransferMode.ANY);
            reset(true);
            dropZoneLabel.setText("Great! Now drop it.");
        }
        dragEvent.consume();
    }

    /**
     * A handler for the drag leave event
     * @param dragEvent
     */
    public void onFileDragLeave(DragEvent dragEvent) {
        dropZoneLabel.setText("Drag and Drop File Here.");
        dragEvent.consume();
    }


    /**
     * A method to reset the textfields by either clearing
     * or changing their styles. The method also removes
     * displayed images from the UI.
     * @param clearTextFields
     */
    private void reset(boolean clearTextFields){
        for (TextField textField:textFields) {
            if(clearTextFields){
                textField.clear();
            }
            textField.setStyle("-fx-background-color: #FFFFFF");
            textField.setStyle("-fx-border-color: #CCC");
        }
        for(ImageView imageView:imageViews){
            imageView.setImage(null);
        }
    }

    /**
     * A method to display the hashes and later
     * call a method to compare with the user input
     */
    private void processHashes(){
        md5HashTextBox.setText(hashes[0]);
        sha1HashTextBox.setText(hashes[1]);
        sha256HashTextBox.setText(hashes[2]);
        makeComparisons();
    }

    /**
     * A method that ensures that none of the indicated
     * text fields are empty.
     * @return
     */
    private boolean checkForHashes(){
        return !md5HashTextBox.getText().equals("") && !sha1HashTextBox.getText().equals("") && !sha256HashTextBox.getText().equals("");
    }

    /**
     * A method to compare a specific hash to a user input
     */
    private void makeComparisons(){
        String inputHash = givenHashTextBox.getText();
        if (!inputHash.equals(""))
        {
            if (inputHash.length() == MD5_LENGTH)
            {
                compareHashes(inputHash, hashes[0], md5HashTextBox, statusIconMD5);
            }
            else if (inputHash.length() == SHA1_LENGTH)
            {
                compareHashes(inputHash, hashes[1], sha1HashTextBox, statusIconSHA1);
            }
            else if (inputHash.length() == SHA256_LENGTH)
            {
                compareHashes(inputHash, hashes[2], sha256HashTextBox, statusIconSHA256);
            }
            else
            {
                noMatchState();
            }
        }
    }

    /**
     * A method that sets the appropriate colors and images
     * if the input doesnt match any calculated hash.
     */
    private void noMatchState(){
        for(int i = 0; i < imageViews.length; i++)
        {
            setStatusDisplay(textFields[i], imageViews[i], false);
        }
    }

    /**
     * A method to compare user input to a given hash
     * and give the appropriate feedback
     * @param input
     * @param hash
     * @param textField
     * @param imageView
     */
    private void compareHashes(String input, String hash, TextField textField, ImageView imageView){
        if(input.toLowerCase().equals(hash.toLowerCase())){
            setStatusDisplay(textField,imageView,true);
        }else{
            setStatusDisplay(textField,imageView,false);
        }
    }

    /**
     * A method responsible to manipulation of the control style
     * and state of image display
     * @param textField
     * @param imageView
     * @param success
     */
    private void setStatusDisplay(TextField textField,ImageView imageView,boolean success){
        if(success){
            textField.setStyle("-fx-background-color: #C0FFC0");
            imageView.setImage(check);
        }else{
            textField.setStyle("-fx-background-color: #FFC0C0");
            imageView.setImage(cancel);
        }
    }

    /**
     * Creates a dialog window with an error message when required
     * @param message
     */
    private void showError(String message){
        new Alert(Alert.AlertType.ERROR,message, ButtonType.CLOSE).showAndWait();
    }



}
