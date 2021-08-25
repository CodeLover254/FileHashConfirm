module org.limepietechnologies {
    requires javafx.controls;
    requires javafx.fxml;

    opens org.limepietechnologies to javafx.fxml;
    exports org.limepietechnologies;
}