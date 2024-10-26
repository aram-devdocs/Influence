// ui.cpp
#include <SFML/Graphics.hpp>
#include "components/window.ui.cpp"
#include "components/button.ui.cpp"
#include "components/table.ui.cpp"
#include "components/form.ui.cpp"

class UI {
public:
    UI() 
        : windowUI(800, 600, "UI Example"), 
          buttonUI("Click Me", {100, 100}, {200, 50}),
          tableUI(3, 3, {100, 50}),
          formUI({400, 300}, {200, 50})
    {}

    void run() {
        while (windowUI.isOpen()) {
            windowUI.processEvents();

            windowUI.clear();
            render();
            windowUI.display();
        }
    }

private:
    WindowUI windowUI;
    ButtonUI buttonUI;
    TableUI tableUI;
    FormUI formUI;

    void render() {
        auto& window = windowUI.getWindow();
        buttonUI.draw(window);
        tableUI.draw(window);
        formUI.draw(window);
    }
};