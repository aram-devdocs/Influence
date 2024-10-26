// form.ui.cpp
#include <SFML/Graphics.hpp>

class FormUI {
public:
    FormUI(const sf::Vector2f& position, const sf::Vector2f& size) {
        inputBox.setSize(size);
        inputBox.setPosition(position);
        inputBox.setFillColor(sf::Color::White);

        font.loadFromFile("path/to/font.ttf"); // Make sure to provide a path
        text.setFont(font);
        text.setCharacterSize(20);
        text.setFillColor(sf::Color::Black);
        text.setPosition(position.x + 5, position.y + 5);
    }

    void handleEvent(const sf::Event& event) {
        if (event.type == sf::Event::TextEntered) {
            if (event.text.unicode == '\b' && !input.empty()) // Handle backspace
                input.pop_back();
            else if (event.text.unicode < 128) // ASCII characters only
                input += static_cast<char>(event.text.unicode);

            text.setString(input);
        }
    }

    void draw(sf::RenderWindow& window) {
        window.draw(inputBox);
        window.draw(text);
    }

private:
    sf::RectangleShape inputBox;
    sf::Text text;
    sf::Font font;
    std::string input;
};