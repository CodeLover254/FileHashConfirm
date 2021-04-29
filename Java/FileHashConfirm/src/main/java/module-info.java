module org.limepietechnologies {
    requires javafx.controls;
    requires javafx.fxml;
    requires com.google.common;

    opens org.limepietechnologies to javafx.fxml;
    exports org.limepietechnologies;
}