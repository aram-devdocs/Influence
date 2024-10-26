// window.ui.cpp
#include <SFML/Graphics.hpp>

class WindowUI {
public:
    WindowUI(int width, int height, const std::string& title) 
        : window(sf::VideoMode(width, height), title) {}

    bool isOpen() const { return window.isOpen(); }

    void processEvents() {
        sf::Event event;
        while (window.pollEvent(event)) {
            if (event.type == sf::Event::Closed)
                window.close();
        }
    }

    void clear() { window.clear(sf::Color::Black); }

    void display() { window.display(); }

    sf::RenderWindow& getWindow() { return window; }

private:
    sf::RenderWindow window;
};